using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soapApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceReference1.SomeSoapServiceClient soapService = new ServiceReference1.SomeSoapServiceClient())
            {
                string subject = "tet882224";
                ServiceReference1.SendEmailResponse res = soapService.SendEmail(new ServiceReference1.SendEmail { subject = subject });
                Console.WriteLine($@"Email from SOAP sent {(res.SendEmailResult.Value ? "successfully" : "unsuccessfully")}!");
            }
        }
    }
}
