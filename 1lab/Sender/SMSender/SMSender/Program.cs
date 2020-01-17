using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Sender1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (SmtpClient C = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("valentain.sav99@gmail.com", "v16111999"),
                    EnableSsl = true
                })
                {
                    string bodyMes = DateTime.Now.ToString() + " TEST";
                    C.Send(new MailMessage("valentain.sav99@gmail.com", "380666063872@sms.vodafone.net", "TEST", bodyMes));
                }
            }
            catch (ArgumentException e)
            {
                
            }
        }
    }
}