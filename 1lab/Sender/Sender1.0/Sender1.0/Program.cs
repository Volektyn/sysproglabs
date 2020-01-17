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
                
                if (args.Length != 2)
                {
                    throw new ArgumentException();
                }
                else
                {
                    SmtpClient C = new SmtpClient("smtp.gmail.com")
                    {
                        Port = 587,
                        Credentials = new NetworkCredential("login", "password"),
                        EnableSsl = true
                    };
                    string bodyMes = DateTime.Now.ToString() + " TEST";
                    C.Send(new MailMessage("login", args[0], "LAB1 " + args[1], bodyMes));
                    C.Dispose();
                }
                
            }
            catch(ArgumentException e)
            {
                Console.WriteLine("CORRECT SYNTAX: e-mail theme");
            }
        }
    }
}

//Відкрийте VisualStudio, напишіть і виконайте консольну програму(проект C#/Console Application), яка відправляє на задану Email-адресу
//    повідомлення з темою "LAB-1" і текстом, що складається з дати, часу, вашого імені і прізвища. 
//    Програма повинна мати два обов'язкових параметра, що вводяться через пробіл. Першим параметром є Email-адреса отримувача, 
//    другим - тема повідомлення. Якщо программа запускається без двох параметрів, повинен бути виведений хелп з правильним синтаксисом.
//   Заздалегідь відкрийте свою поштову скриню і після запуску програми промонструйте наявність щойно отриманого повідомлення.
//    Якщо Вам вдалось відправити SMS/Telegram/Viber/WhatsUp-повідомлення — продемонструйте це викладачеві і отримайти додаткові бали.


//SmtpClient C = new SmtpClient("smtp.gmail.com")
//{
//Port = 587,
//Credentials = new NetworkCredential("valentain.sav99@gmail.com", "v16111999"),
//EnableSsl = true
//};
//string bodyMes = DateTime.Now.ToString() + " Тримай цмок :*";//" Щербань Валентин";
//C.Send(new MailMessage("valentain.sav99@gmail.com", "olya.shevchenko277@gmail.com", "хехехе", bodyMes));