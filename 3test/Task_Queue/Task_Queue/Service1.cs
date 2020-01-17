using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.Timers;
using System.Threading;
using Timer = System.Timers.Timer;

namespace Task_Queue
{
    public partial class Service1 : ServiceBase
    {
        int TaskExecutionDuration;
        int CheckPeriod;
        int ExecutionQuantity;
        List<string> taskQuery;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            TaskExecutionDuration = GetTaskExecutionDuration()*1000;
            CheckPeriod = GetCheckPeriod()*1000;
            ExecutionQuantity = GetExecutionQuantity();

            System.Timers.Timer t = new Timer(CheckPeriod);
            t.Elapsed += new ElapsedEventHandler(WorkingCycleThread1);
            t.Enabled = true;
            System.Threading.Thread thread = new System.Threading.Thread(WorkingCycleThread2);
            thread.Start();
        }

        void WorkingCycleThread2()
        {
            try
            {
                Queue<string> tasks;
                taskQuery = new List<string>();
                string task;
                Thread[] threads = new Thread[ExecutionQuantity];
                while (true)
                {
                    task = getTasks();
                    if (taskQuery.Count < ExecutionQuantity && task != "")
                    {
                        taskQuery.Add(task);
                        threads[taskQuery.Count - 1] = new Thread(DoIt);
                        threads[taskQuery.Count - 1].Start(task);
                        //DoIt(names[0]);
                    }
                    Thread.Sleep(10);
                }
            }
            catch(Exception e) { WriteDebugLog(e.Message); }
        }

        string getTasks()
        {
            try
            { 
                List<string> taskNames = new List<string>();
                /*string val;
                using (RegistryKey v = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Task_Queue\Tasks", true))
                {
                    taskNames = v.GetValueNames().ToList();

                    for (int i = 0; i < taskNames.Count; i++)
                    {
                        val = (string)v.GetValue(taskNames[i]);
                        if (val.Length >= 30) { taskNames.Remove(taskNames[i]); i--; }
                    }
                }*/
                using (StreamReader sr = new StreamReader(@"C:\Windows\Task_Queue\Tasks.txt"))
                {
                    string str;
                    while ((str = sr.ReadLine()) != null)
                    {
                        taskNames.Add(str);
                    }
                }
                taskNames.Sort();
                return (taskNames.Count > 0) ? taskNames[0] : "";
            }
            catch (Exception e)
            {
                WriteDebugLog(e.Message);
                return "";
            }
        }

        void DoIt(object p)
        {
            try
            {
                string param = (string)p;

                StringBuilder stringBuilder = new StringBuilder("[....................]", 22);
                /*using (RegistryKey v = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Task_Queue\Tasks", true))
                {
                    v.SetValue(param, "[....................]-In progress 0 % completed");
                    for (int i = 1; i <= 20; i++)
                    {
                        stringBuilder[i] = 'I';
                        v.SetValue(param, stringBuilder + $"In progress {i * 5} % completed");
                        Thread.Sleep(TaskExecutionDuration / 20);
                    }
                    v.SetValue(param, "[IIIIIIIIIIIIIIIIIIII]-COMPLETED");

                }*/
                using (StreamWriter sw = new StreamWriter(@"C:\Windows\Task_Queue\Tasks.txt", true))
                {
                    sw.WriteLine(param, "[....................]-In progress 0 % completed");
                    for (int i = 0; i < 21; i++)
                    {
                        stringBuilder[i] = 'I';
                        
                    }
                }
                taskQuery.Remove(param);
                WriteLog($"Задача {param} успішно виконана");
            }
            catch (Exception e)
            {
                WriteDebugLog(e.Message);
                //Debugger.Launch();
            }
        }

        static void WorkingCycleThread1(object source, ElapsedEventArgs e)
        {
            getClaims();
        }

        static void getClaims()
        {
            Regex reg = new Regex("Task_[0-9]{4}");
            List<string> claims = new List<string>();
            using (StreamReader sr = new StreamReader(@"C:\Windows\Task_Queue\Claims.txt"))
            {
                while (sr.Peek() >= 0)
                {
                    claims.Add(sr.ReadLine());
                }
            }
            claims.Remove("=====[ CLAIMS ]=====");
            foreach(string str in claims)
            {
                Match m = reg.Match(str);
                if (!m.Success)
                {
                    WriteLog($"ПОМИЛКА розміщення заявки {str}. Некоректний синтаксис ...");
                    claims.Remove(str);
                    deleteClaim(str);
                }
            }
            checkIfOne(claims);
            //claims.Sort();
            if (claims.Count > 0)
            {
                writeTask(claims[0]);
                WriteLog($"Задача {claims[0]} успішно прийнята в обробку");
                deleteClaim(claims[0]);
            }
            
        }

        static void checkIfOne(List<string> claims)
        {
            claims.Sort();
            for (int i = 0; i < claims.Count; i++)
            {
                if(claims[i] == claims[i + 1])
                {
                    WriteLog($"ПОМИЛКА розміщення заявки {claims[i]}. Номер вже існує ...");
                    claims.Remove(claims[i]);
                    deleteClaim(claims[i]);
                }
            }
        }

        static void writeTask(string str)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Windows\Task_Queue\Tasks.txt", true))
            {
                sw.WriteLine($"{str}-[....................]-Queued");
            }
        }

        static void deleteClaim(string claim)
        {
            using (StreamReader sr = new StreamReader(@"C:\Windows\Task_Queue\Claims.txt"))
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Windows\Task_Queue\Claims.txt"))
                {
                    string str;
                    while ((str = sr.ReadLine()) != null)
                    {
                        if(str == claim)
                        {
                            str = "";
                        }

                        sw.WriteLine(str);
                    }
                }
            }
            IEnumerable<string> lines = File.ReadAllLines(@"C:\Windows\Task_Queue\Claims.txt").Where(arg => !string.IsNullOrWhiteSpace(arg));
            File.WriteAllLines(@"C:\Windows\Task_Queue\Claims.txt", lines);
        }

        //get duration value from registry
        int GetTaskExecutionDuration()
        {
            int time = 60;
            try
            {
                using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                using (var runKey = hklm.OpenSubKey(@"SOFTWARE\Task_Queue\Parameters", true))
                {
                    time = (int)runKey.GetValue("Task_Execution_Duration", 60);
                }
                if (CheckParameterRange(time, 30, 180))
                    WriteDebugLog($"TASK EXECUTION DURATION WAS CHANGED TO {time}");
                else
                {
                    using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                    using (var runKey = hklm.OpenSubKey(@"SOFTWARE\Task_Queue\Parameters", true))
                    {
                        runKey.SetValue("Task_Execution_Duration", 60);
                    }
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch(ArgumentOutOfRangeException argEx)
            {
                WriteDebugLog("DURATION HAS TO BE IN RANGE 30-180" + Environment.NewLine + "Task duration was set" +
                "to default value");
            }
            return time;
        }

        //check whether duration in allow range
        bool CheckParameterRange(int param, int min, int max)
        {
            if ((param < min) || (param > max))
                return false;
            return true;
        }

        //get duration value from registry
        int GetCheckPeriod()
        {
            int checkPeriod = 30;
            try
            {
                using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                using (var runKey = hklm.OpenSubKey(@"SOFTWARE\Task_Queue\Parameters", true))
                {
                    checkPeriod = (int)runKey.GetValue("Task_Claim_Check_Period", 30);
                }
                if (CheckParameterRange(checkPeriod, 15, 45))
                    WriteDebugLog($"TASK CHECK PERIOD WAS CHANGED TO {checkPeriod}");
                else
                {
                    using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                    using (var runKey = hklm.OpenSubKey(@"SOFTWARE\Task_Queue\Parameters", true))
                    {
                        runKey.SetValue("Task_Claim_Check_Period", 30);
                    }
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException argEx)
            {
                WriteDebugLog("CHECK PERIOD HAS TO BE IN RANGE 15-45" + Environment.NewLine + "Check period was set" +
"to default value");
            }
            return checkPeriod;
        }

        int GetExecutionQuantity()
        {
            int quantity = 1;
            try
            {
                using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                using (var runKey = hklm.OpenSubKey(@"SOFTWARE\Task_Queue\Parameters", true))
                {
                    quantity = (int)runKey.GetValue("Task_Execution_Quantity", 1);
                }
                if (CheckParameterRange(quantity, 1, 3))
                    WriteDebugLog($"TASK EXECUTION QUANTITY WAS CHANGED TO {quantity}");
                else
                {
                    using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                    using (var runKey = hklm.OpenSubKey(@"SOFTWARE\Task_Queue\Parameters", true))
                    {
                        runKey.SetValue("Task_Execution_Quantity", 1);
                    }
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException argEx)
            {
                WriteDebugLog("EXECUTION QUANTITY HAS TO BE IN RANGE 15-45" + Environment.NewLine + "Execution quantity was set" +
"to default value");
            }
            return quantity;
        }

        static void WriteLog(string log)
        {
            string path = @"C:\Windows\Logs\TaskQueue_18-11-2013.log";
            using(StreamWriter sw = new StreamWriter(path,true))
            {
                sw.Write($"-----------------------------------------{DateTime.Now}----------------------------------------------------------------");
                sw.Write(log + Environment.NewLine);
            }
        }

        static void WriteDebugLog(string log)
        {
            string path = @"C:\Users\Valentyn\Desktop\sysprog\3lab\Debug.log";
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.Write($"-----------------------------------------{DateTime.Now}----------------------------------------------------------------");
                sw.Write(log + Environment.NewLine);
            }
        }

        protected override void OnStop()
        {
        }
    }
}
