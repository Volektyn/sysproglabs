using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Security.AccessControl;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string K = "HKEY_LOCAL_MACHINE\\Software\\Shcherban";
            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            using (var runKey = hklm.OpenSubKey(@"SOFTWARE\Shcherban", true))
            {
                string[] p5 = (string[])runKey.GetValue("P5", new string[] { "CCCC", "DDDDDD" });
                string output = "";
                foreach (string str in p5)
                {
                    output += str + "\n";
                }
                MessageBox.Show(output);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            using (var runKey = hklm.OpenSubKey(@"SOFTWARE\Shcherban", true))
            {
                runKey.SetValue("P6", new string[] { "Я - студент", "кафедри КІ!" }, RegistryValueKind.MultiString);
                MessageBox.Show("Param was successfully recorded");
            }
        }
    }
}
/*Напишіть Windows-програму (проект C#/Windows Forms Application) з двома кнопками. Перша кнопка повинна виводити зміст всіх рядків параметра P5 за допомогою,
 * наприклад, MessageBox.Show(“……”), незалежно від кількості рядків. 
Друга кнопка створює в гілці реєстра
   HKLM/Software/<ВАШЕ ПРІЗВИЩЕ ЛАТИНИЦЕЮ>,
   створює новий параметр P6 типу MultiString і записує в цей параметр два рядки: 

"Я - студент"
"кафедри КІ!"

і виводить повідомлення, що дані успішно внесено в реєстр, за допомогою, наприклад, MessageBox.Show(“……”). 
*/
