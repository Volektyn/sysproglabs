using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WcfClient
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ServiceReference1.Service1Client client = new ServiceReference1.Service1Client())
            {
                try
                {
                    MessageBox.Show($"F4(x, 3) = {client.F4_WebService(double.Parse(xBox.Text))}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Enter number for x");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GetAllButton_Click(object sender, EventArgs e)
        {
            using (ServiceReference1.Service1Client client = new ServiceReference1.Service1Client())
            {
                dataGridView1.DataSource = client.GetAllElements();
            }
        }

        private void GetIDButton_Click(object sender, EventArgs e)
        {
            using (ServiceReference1.Service1Client client = new ServiceReference1.Service1Client())
            {
                try
                {
                    dataGridView1.DataSource = client.GetElementByID(int.Parse(IDbox.Text));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
