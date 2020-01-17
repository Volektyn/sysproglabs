using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.Sql;
using System.Data.SqlClient;


namespace FirstTask
{
    public partial class Form2 : Form
    {
        Form1 parent;
        string DB = @"Data Source=DESKTOP-GMI6RAJ\SQLEXPRESS;Initial Catalog=Apteka;Integrated Security=True";

        public Form2(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            button1.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void GettingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GettingCheckBox.Checked)
            {
                DeletingCheckBox.Enabled = false;
                AddingCheckBox.Enabled = false;
                UpdatingCheckBox.Enabled = false;
                IDTextBox.Enabled = false;
                NameTextBox.Enabled = false;
                DescriptionTextBox.Enabled = false;
            }
            else
            {
                DeletingCheckBox.Enabled = true;
                AddingCheckBox.Enabled = true;
                UpdatingCheckBox.Enabled = true;
                IDTextBox.Enabled = true;
                NameTextBox.Enabled = true;
                DescriptionTextBox.Enabled = true;
            }
            CheckStatus();
        }

        private void AddingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AddingCheckBox.Checked)
            {
                DeletingCheckBox.Enabled = false;
                GettingCheckBox.Enabled = false;
                UpdatingCheckBox.Enabled = false;
                IDTextBox.Enabled = false;
                /*NameTextBox.Enabled = true;
                DescriptionTextBox.Enabled = true;*/
            }
            else
            {
                DeletingCheckBox.Enabled = true;
                GettingCheckBox.Enabled = true;
                UpdatingCheckBox.Enabled = true;
                IDTextBox.Enabled = true;
            }
            CheckStatus();
        }

        private void UpdatingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdatingCheckBox.Checked)
            {
                DeletingCheckBox.Enabled = false;
                GettingCheckBox.Enabled = false;
                AddingCheckBox.Enabled = false;
            }
            else
            {
                DeletingCheckBox.Enabled = true;
                GettingCheckBox.Enabled = true;
                AddingCheckBox.Enabled = true;
            }
            CheckStatus();
        }

        private void DeletingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DeletingCheckBox.Checked)
            {
                UpdatingCheckBox.Enabled = false;
                GettingCheckBox.Enabled = false;
                AddingCheckBox.Enabled = false;
                NameTextBox.Enabled = false;
                DescriptionTextBox.Enabled = false;
                //IDTextBox.Enabled = true;
            }
            else
            {
                UpdatingCheckBox.Enabled = true;
                GettingCheckBox.Enabled = true;
                AddingCheckBox.Enabled = true;
                NameTextBox.Enabled = true;
                DescriptionTextBox.Enabled = true;
                //IDTextBox.Enabled = true;
            }
            CheckStatus();
        }

        public void CheckStatus()
        {

            if (!GettingCheckBox.Checked && !DeletingCheckBox.Checked && !AddingCheckBox.Checked && !UpdatingCheckBox.Checked)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parent.Show();
            parent.fillCategories();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "";
            string res = "";
            int flag = 0;
            Regex check1 = new Regex("^.*[^A-zА-яЁё].*$");
            Regex check2 = new Regex("^[0-9]+$");
            Match idRes = check2.Match(IDTextBox.Text);
            Match nameRes = check1.Match(NameTextBox.Text);
            Match descriptionRes = check1.Match(DescriptionTextBox.Text);

            if (GettingCheckBox.Checked)
            {
                res = "raw(s) selected";
                query = "select * from dbo.Drug_Category";
            }
            else if (AddingCheckBox.Checked)
            {
                if (!nameRes.Success && !descriptionRes.Success)
                {
                    res = "1 raw added";
                    query = "INSERT INTO dbo.Drug_Category ([Name],[Description]) VALUES ('" + NameTextBox.Text + "','" + DescriptionTextBox.Text + "')";
                }
                else
                {
                    MessageBox.Show("Error!");
                    flag++;
                }
            }
            else if (UpdatingCheckBox.Checked)
            {
                if (!nameRes.Success && !descriptionRes.Success && idRes.Success)
                {
                    res = "1 raw updated";
                    query = "UPDATE dbo.Drug_Category SET Name = '" + NameTextBox.Text + "', Description = '" + DescriptionTextBox.Text + "' WHERE Category_ID =" + IDTextBox.Text;
                }
                else
                {
                    MessageBox.Show("Error!");
                    flag++;
                }
            }
            else if (DeletingCheckBox.Checked)
            {
                if (idRes.Success)
                {
                    res = "1 row(s) deleted";
                    query = "delete from dbo.Drug_Category where Category_ID = " + IDTextBox.Text;
                }
                else
                {
                    MessageBox.Show("Error!");
                    flag++;
                }
            }
            if (flag == 0)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(DB))
                    {
                        conn.Open();
                        SqlDataAdapter adapt = new SqlDataAdapter(query, conn);
                        DataSet data = new DataSet();
                        adapt.Fill(data);
                        dataGridView1.Visible = true;
                        if (GettingCheckBox.Checked)
                        {
                            dataGridView1.DataSource = data.Tables[0];
                            res = res.Insert(0, data.Tables[0].Rows.Count.ToString());
                        }
                        else
                        {
                            adapt = new SqlDataAdapter("select * from Drug_Category", DB);
                            data = new DataSet();
                            adapt.Fill(data);
                            dataGridView1.DataSource = data.Tables[0];
                            textBoxRes.Text = res;
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                IDTextBox.Text = "";
                NameTextBox.Text = "";
                DescriptionTextBox.Text = "";
            }
        }
    }
}
