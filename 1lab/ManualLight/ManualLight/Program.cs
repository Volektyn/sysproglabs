using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.IO;
using System.Net;

namespace C_13Mar2012
{
    class Program
    {
        static void Main(string[] args)
        {
            string delWord = "", 
                modWord = "";
            if (args.Length == 2)
            {
                delWord = args[0];
                modWord = args[1];
                string fullFile = @"C:\textDirectory\Test.txt",
                lightFile = @"C:\textDirectory\Manual-LIGHT.txt";

                Recover(fullFile);
                Recover(lightFile);
                GetTextFile("http://mail.univ.net.ua/manual.txt", fullFile);
                MakeLightVersion(fullFile, lightFile, modWord, delWord);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        //Get text from url and write it to file
        static void GetTextFile(string url, string filePath)
        {
            try
            {
                // HTTP Server:
                string download;
                using (WebClient W = new WebClient())
                {
                    download = W.DownloadString(url);
                    //W.UploadString("http://mail.univ.net.ua/manual.txt", "777777777777");
                }
                using (StreamWriter stream = new StreamWriter(filePath))
                {
                    stream.Write(download);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        //Make light version of file Manual-Light.txt
        static void MakeLightVersion(string readingFile, string writingFile,
            string modWord, string delWord)
        {
            try
            {
                string str;
                using (StreamReader sr = new StreamReader(readingFile))
                {
                    using (StreamWriter sw = new StreamWriter(writingFile))
                    {
                        sw.Write("");
                        string strNoReg;
                        delWord = delWord.ToLower();
                        modWord = modWord.ToLower();
                        while ((str = sr.ReadLine()) != null)
                        {
                            strNoReg = str.ToLower();
                            if (strNoReg.Contains(delWord) || strNoReg.Contains("chip"))
                            {
                                str = "";
                            }
                            else if (strNoReg.Contains(modWord))
                            {
                                str = "MODIFIED";
                            }

                            sw.WriteLine(str);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        //Rewrite file
        static void Recover(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                File.Create(filePath).Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
