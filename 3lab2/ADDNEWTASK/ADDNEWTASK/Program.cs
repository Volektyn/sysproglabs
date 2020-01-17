using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ADDNEWTASK
{
    class Program
    {

        static void Main(string[] args)
        {
            string number = args[0];
            AddTask(number);
        }

        static void AddTask(string number)
        {
            string path = @"C:\Windows\Task_Queue\Claims.txt";
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("Task_" + number);
            }
        }
    }
}
