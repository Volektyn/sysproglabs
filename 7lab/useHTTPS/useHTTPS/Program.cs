using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace useHTTPS
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            Console.WriteLine($"Your IP-adress: {client.MyIPAddress()}");

            Console.WriteLine("Input login");
            if (client.IsLoginFree(Console.ReadLine()))
            {
                Console.WriteLine("Login is free");
            }
            else
            {
                Console.WriteLine("Login is occupied");
            }
            Console.ReadLine();
        }
    }
}
