using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace restApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebClient W = new WebClient())
            {
                string baseAddress = "http://192.168.74.139:5003/misc/SendEmail";
                var http = (HttpWebRequest)WebRequest.Create(new Uri(baseAddress));
                http.Accept = "application/json";
                http.ContentType = "application/json";
                http.Method = "POST";

                string parsedContent = "{ \"subject\": \"22999777\" }";
                byte[] bytes = Encoding.ASCII.GetBytes(parsedContent);
                using (Stream newStream = http.GetRequestStream())
                {
                    newStream.Write(bytes, 0, bytes.Length);
                }

                StreamReader sr = new StreamReader(http.GetResponse().GetResponseStream());
                string content = sr.ReadToEnd();
                Console.WriteLine($"Response from REST service: {content}");
            }
        }
    }
}
