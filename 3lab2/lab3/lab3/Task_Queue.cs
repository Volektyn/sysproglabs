using System;
using System.Collections.Generic;
using System.ServiceProcess;
using System.Text;
using System.Timers;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace lab3
{
    public partial class Task_Queue : ServiceBase
    {
        public Task_Queue()
        {
            InitializeComponent();
        }

        const string readpath = @"C:\Windows\Task_Queue\Claims.txt";
        const string writepath = @"C:\Windows\Task_Queue\Tasks.txt";
        const int TASKDOER_INTERVAL = 2000; // ms

        private class PseudoTask
        {
            public PseudoTask(string taskNumber, DateTime startTime, int percents)
            {
                this.taskNumber = taskNumber;
                this.startTime = startTime;
                this.percents = percents;
            }
            public bool completed = false;
            public string taskNumber;
            public int percents;
            public DateTime startTime;
        }

        Timer taskExecutorTimer;
        Timer claimProcessTimer;
        int claimProcessInterval;
        int maxTask;
        int taskDuration;
        List<PseudoTask> processingTasks;
        Queue<PseudoTask> queuedTasks;
        StreamWriter logger;
        StreamWriter claimerwr;
        StreamReader claimerrd;
        System.Threading.Mutex tasksMutex;

        protected override void OnStart(string[] args)
        {
            logger = new StreamWriter($"C:/Windows/Logs/TaskQueue_{DateTime.Now.ToString("dd.MM.yyyy")}.log", true);
            processingTasks = new List<PseudoTask>();
            queuedTasks = new Queue<PseudoTask>();
            tasksMutex = new System.Threading.Mutex();
            try
            {
                if (!File.Exists($@"{writepath}"))
                {
                    using (StreamWriter wr = new StreamWriter(File.Open($@"{writepath}", FileMode.Create, FileAccess.Write), Encoding.UTF8))
                    {
                        wr.WriteLine("=====[ TASKS ]=====");
                    }
                }
                var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                RegistryKey options = hklm.OpenSubKey(@"SOFTWARE\Task_Queue\Parameters");
                claimProcessInterval = GetIntRegistryKey(options, "Task_Claim_Check_Period");
                if (claimProcessInterval < 10 || 45 < claimProcessInterval)
                    throw new Exception("Claim interval registry parameter out of range [10, 45] seconds");
                claimProcessInterval *= 1000; // s to ms
                taskDuration = GetIntRegistryKey(options, "Task_Execution_Duration");
                if (taskDuration < 30 || 180 < taskDuration)
                    throw new Exception("Task duration registry parameter out of range [30, 180] seconds");
                taskDuration *= 1000; // s to ms
                maxTask = GetIntRegistryKey(options, "Task_Execution_Quantity");
                if (maxTask < 1 || 3 < maxTask)
                    throw new Exception("Task execution quantity registry parameter out of range [1, 3]");
                taskExecutorTimer = new Timer(TASKDOER_INTERVAL)
                {
                    AutoReset = false
                };
                claimProcessTimer = new Timer(claimProcessInterval)
                {
                    AutoReset = false
                };
                taskExecutorTimer.Elapsed += TaskExecutor;
                claimProcessTimer.Elapsed += ClaimProcesser;
                Log("Service started");
                claimProcessTimer.Start();
                taskExecutorTimer.Start();
            }
            catch (Exception ex)
            {
                if (!(claimProcessTimer is null))
                    claimProcessTimer.Stop();
                if (!(taskExecutorTimer is null))
                    taskExecutorTimer.Stop();
                Log(ex.Message);
                logger.Close();
            }
        }

        private int GetIntRegistryKey(RegistryKey options, string v)
        {
            object vObj = options.GetValue(v);
            if (vObj is null)
                throw new Exception($"{v} option at {options.Name} not found");
            return (int)vObj;
        }

        private void Log(string mess)
        {
            logger.WriteLine($"------{DateTime.Now.ToString("dd.MM.yyyy")} / {DateTime.Now.ToString("HH:mm")}------\n{mess}");
            logger.Flush();
        }

        private void ClaimProcesser(object sender, ElapsedEventArgs e)
        {
            tasksMutex.WaitOne();
            Regex regex1 = new Regex("^Task_[0-9]{4}$");
            Regex regex2 = new Regex(@"^Task_[0-9]{4}\([0-9]{1,2}\)$");
            string pseudoClaim;
            List<string> editedTasks;
            try
            {
                using (claimerrd = new StreamReader(readpath, Encoding.Default))
                {
                    claimerrd.ReadLine();
                    pseudoClaim = claimerrd.ReadLine();
                }
                if (!String.IsNullOrEmpty(pseudoClaim))
                {
                    List<PseudoTask> tasksInQueue = new List<PseudoTask>(queuedTasks.ToArray());
                    if (!regex1.IsMatch(pseudoClaim) && !regex2.IsMatch(pseudoClaim))
                        Log($"ПОМИЛКА розміщення заявки {pseudoClaim}. Некоректний синтаксис.");
                    else if (processingTasks.FindIndex(task => task.taskNumber == pseudoClaim) != -1 || tasksInQueue.FindIndex(task => task.taskNumber == pseudoClaim) != -1)
                        Log($"ПОМИЛКА розміщення заявки {pseudoClaim}. Номер вже існує.");
                    else if (regex2.IsMatch(pseudoClaim))
                    {
                        string tasknmbr = pseudoClaim.Substring(0, pseudoClaim.Length - 4);
                        string test = pseudoClaim.Substring(0, pseudoClaim.Length - 1);
                        int.TryParse(test.Substring(10), out int perc);
                        string progressbar = new string('I', perc / 5) + new string('.', 20 - (perc / 5));
                        using (claimerwr = new StreamWriter(writepath, true, Encoding.UTF8))
                        {
                            claimerwr.WriteLine($"{tasknmbr}-[{progressbar}]-In progress - {perc} percents");
                        }
                        DateTime.TryParse($"perc * taskDuration / 100", out DateTime res);
                        PseudoTask inctask = new PseudoTask(tasknmbr, DateTime.Now.AddMilliseconds(-taskDuration * perc / 100), perc);
                        processingTasks.Add(inctask);
                        Log($"Задача {tasknmbr} успішно продовжила свою роботу з {perc}%.");
                    }
                    else
                    {
                        using (claimerwr = new StreamWriter(writepath, true, Encoding.UTF8))
                        {
                            claimerwr.WriteLine($"{pseudoClaim}-[....................]-Queued");
                        }
                        queuedTasks.Enqueue(new PseudoTask(pseudoClaim, DateTime.Now, 0));
                        Log($"Задача {pseudoClaim} успішно прийнята в обробку.");
                    }
                    using (claimerrd = new StreamReader(readpath, Encoding.Default))
                    {
                        editedTasks = new List<string>(claimerrd.ReadToEnd().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries));
                        editedTasks.Remove($"{pseudoClaim}");
                    }
                    using (claimerwr = new StreamWriter(readpath, false, Encoding.Default))
                    {
                        foreach (string str in editedTasks)
                        {
                            claimerwr.WriteLine(str);
                        }
                    }
                }
                tasksMutex.ReleaseMutex();
                claimProcessTimer.Start();
            }
            catch (Exception ex)
            {
                Log($"Error in ClaimProcesser: {ex.Message}");
            }
        }

        private void TaskExecutor(object sender, ElapsedEventArgs e)
        {
            tasksMutex.WaitOne();
            string[] tasks;
            int index = 0;
            DateTime now = DateTime.Now;
            try
            {
                using (claimerrd = new StreamReader(writepath, Encoding.Default))
                {
                    tasks = claimerrd.ReadToEnd().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                }
                for (int i = 1; i < tasks.Length; i++)
                {
                    if (!tasks[i].EndsWith("COMPLETED"))
                    {
                        index = i;
                        break;
                    }
                }
                if (processingTasks.Count != 0)
                {
                    foreach (PseudoTask pt in processingTasks)
                    {
                        double elapsed = (now - pt.startTime).TotalMilliseconds;
                        if (elapsed >= taskDuration)
                        {
                            tasks[index] = $"{pt.taskNumber}-[IIIIIIIIIIIIIIIIIIII]-COMPLETED";
                            Log($"Задача {pt.taskNumber} успішно ВИКОНАНА!");
                            pt.completed = true;
                            pt.percents = 100;
                        }
                        else
                        {
                            int percents = (int)((elapsed / taskDuration) * 100);
                            string progressbar = new string('I', percents / 5) + new string('.', 20 - (percents / 5));
                            tasks[index] = $"{pt.taskNumber}-[{progressbar}]-In progress - {percents} percents";
                            pt.percents = percents;
                        }
                        index++;
                    }
                }
                processingTasks.RemoveAll(task => task.completed);
                while (processingTasks.Count < maxTask && queuedTasks.Count > 0)
                {
                    PseudoTask task = queuedTasks.Dequeue();
                    task.startTime = DateTime.Now;
                    processingTasks.Add(task);
                    tasks[index] = $"{task.taskNumber}-[....................]-In Progress - 0 percents";
                    index++;
                }
                using (claimerwr = new StreamWriter(writepath, false, Encoding.Default))
                {
                    foreach (string str in tasks)
                    {
                        claimerwr.WriteLine(str);
                    }
                }
                tasksMutex.ReleaseMutex();
                taskExecutorTimer.Start();
            }
            catch (Exception ex)
            {
                Log($"Error in TaskDoer: {ex.Message}");
            }
        }

        protected override void OnStop()
        {
        }
    }
}
