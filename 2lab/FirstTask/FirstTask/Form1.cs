using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace FirstTask
{
    public partial class Form1 : Form
    {
        //public ComboBox categories;
        Form2 categoryForm;
        string DB = @"Data Source=DESKTOP-GMI6RAJ\SQLEXPRESS;Initial Catalog=Apteka;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            CategoryCheckBox.Enabled = false;
            IDCheckBox.Enabled = false;
            button1.Enabled = false;
        }

        //check whether DB has two records 
        public void checkDB()
        {
            try
            {
                using (SqlConnection sc = new SqlConnection(DB))
                {
                    sc.Open();
                    SqlDataAdapter da = new SqlDataAdapter(@"SELECT * FROM dbo.Scope_Of_Drug_Using", sc);
                    DataSet data = new DataSet();
                    da.Fill(data);
                    if (data.Tables[0].Rows.Count == 0)
                    {
                        da = new SqlDataAdapter(@"INSERT INTO dbo.Drug_Category ([Name], [Description]) VALUES (N'Aids', N'For first help')", sc);
                        da.Fill(data);
                    }
                    da = new SqlDataAdapter(@"select * from dbo.Drug_Category where Name = N'Alcohol'", sc);
                    data.Reset();
                    da.Fill(data);
                    if (data.Tables[0].Rows.Count == 0)
                    {
                        da = new SqlDataAdapter(@"INSERT INTO dbo.Drug_Category ([Name], [Description]) VALUES (N'Alcohol', N'For second help')", sc);
                        da.Fill(data);
                    }
                    /*if (data.Tables[0].Rows.Count < 2)
                    {
                        da = new SqlDataAdapter(@"DELETE FROM dbo.Drug_Category", sc);
                        da.Fill(data);
                        da = new SqlDataAdapter(@"INSERT INTO dbo.Drug_Category ([Name], [Description]) VALUES (N'Aids', N'For first help')", sc);
                        da.Fill(data);
                        da = new SqlDataAdapter(@"INSERT INTO dbo.Drug_Category ([Name], [Description]) VALUES (N'Alcohol', N'For second help')", sc);
                        da.Fill(data);
                    }*/
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkDB();
            fillCategories();
        }

        //fill combobox
        public void fillCategories()
        {
            try
            {
                DataSet data = new DataSet();
                using (SqlConnection sc = new SqlConnection(DB))
                {
                    sc.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT NAME FROM dbo.Drug_Category", DB);
                    da.Fill(data);
                }
                CategoryComboBox.Items.Clear();
                for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                {
                    CategoryComboBox.Items.Add(data.Tables[0].Rows[i][0]);
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
            }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        /*private void drug_CategoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.drug_CategoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aptekaDataSet);

        }*/
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (gettingCheckBox.Checked)
            {
                deletingCheckBox.Enabled = false;
                addingCheckBox.Enabled = false;
                updatingCheckBox.Enabled = false;
                CategoryCheckBox.Enabled = true;
                IDCheckBox.Enabled = true;
                ScopeTextBox.Enabled = false;
                RecipeTextBox.Enabled = false;
                LegalityTextBox.Enabled = false;
                InstructionTextBox.Enabled = false;
            }
            else
            {
                deletingCheckBox.Enabled = true;
                addingCheckBox.Enabled = true;
                updatingCheckBox.Enabled = true;
                CategoryCheckBox.Enabled = false;
                IDCheckBox.Enabled = false;
                ScopeTextBox.Enabled = true;
                RecipeTextBox.Enabled = true;
                LegalityTextBox.Enabled = true;
                InstructionTextBox.Enabled = true;
            }
            CheckStatus();
        }

        private void addingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (addingCheckBox.Checked)
            {
                deletingCheckBox.Enabled = false;
                gettingCheckBox.Enabled = false;
                updatingCheckBox.Enabled = false;
                IDTextBox.Enabled = false;
                /*ScopeTextBox.Enabled = true;
                RecipeTextBox.Enabled = true;
                LegalityTextBox.Enabled = true;
                InstructionTextBox.Enabled = true;
                CategoryComboBox.Enabled = true;*/
            }
            else
            {
                deletingCheckBox.Enabled = true;
                gettingCheckBox.Enabled = true;
                updatingCheckBox.Enabled = true;
                IDTextBox.Enabled = true;
            }
            CheckStatus();
        }

        private void updatingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (updatingCheckBox.Checked)
            {
                deletingCheckBox.Enabled = false;
                gettingCheckBox.Enabled = false;
                addingCheckBox.Enabled = false;
                /*ScopeTextBox.Enabled = true;
                RecipeTextBox.Enabled = true;
                LegalityTextBox.Enabled = true;
                InstructionTextBox.Enabled = true;
                IDTextBox.Enabled = true;
                CategoryComboBox.Enabled = true;*/
            }
            else
            {
                deletingCheckBox.Enabled = true;
                gettingCheckBox.Enabled = true;
                addingCheckBox.Enabled = true;
            }
            CheckStatus();
        }

        private void deletingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (deletingCheckBox.Checked)
            {
                updatingCheckBox.Enabled = false;
                gettingCheckBox.Enabled = false;
                addingCheckBox.Enabled = false;
                ScopeTextBox.Enabled = false;
                RecipeTextBox.Enabled = false;
                LegalityTextBox.Enabled = false;
                InstructionTextBox.Enabled = false;
                IDTextBox.Enabled = true;
                CategoryComboBox.Enabled = false;
            }
            else
            {
                updatingCheckBox.Enabled = true;
                gettingCheckBox.Enabled = true;
                addingCheckBox.Enabled = true;
                ScopeTextBox.Enabled = true;
                RecipeTextBox.Enabled = true;
                LegalityTextBox.Enabled = true;
                InstructionTextBox.Enabled = true;
                IDTextBox.Enabled = true;
                CategoryComboBox.Enabled = true;
            }
            CheckStatus();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void IDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void CheckStatus()
        {

            if (!gettingCheckBox.Checked && !deletingCheckBox.Checked && !addingCheckBox.Checked && !updatingCheckBox.Checked)
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
            categoryForm = new Form2(this);
            categoryForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            string query = "";
            string res = "";
            int flag = 0;
            Regex check1 = new Regex("^.*[^A-zА-яЁё].*$");
            Regex check2 = new Regex("^[0-9]+$");
           // Regex check3 = new Regex("^[(yes)(no)]$");
            Match InstructionRes = check1.Match(InstructionTextBox.Text);
            Match ScopeRes = check1.Match(ScopeTextBox.Text);
            Match LegalityRes = check2.Match(LegalityTextBox.Text);
            Match RecipeRes = check2.Match(RecipeTextBox.Text);
            Match idRes = check2.Match(IDTextBox.Text);

            if (gettingCheckBox.Checked)
            {
                if (IDCheckBox.Checked && !CategoryCheckBox.Checked)
                {
                    if (idRes.Success)
                    {
                        res = "row(s) selected";
                        //query = "select * from dbo.Scope_Of_Drug_Using join dbo.Drug_Category On Scope_Of_Drug_Using.Category_ID = Drug_Category.Category_ID";
                        if (int.TryParse(IDTextBox.Text, out id))
                        {
                            query += "select * from dbo.Scope_Of_Drug_Using where Scope_Of_Drug_Using.Scope_ID = " + IDTextBox.Text;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                        flag++;
                    }
                }
                else if (CategoryCheckBox.Checked && !IDCheckBox.Checked)
                {
                    if (CategoryComboBox.Text.Length != 0)
                    {
                        res = "row(s) selected";
                        query = $"SELECT * FROM dbo.Scope_Of_Drug_Using WHERE Scope_Of_Drug_Using.Category_ID = (SELECT Drug_Category.Category_ID FROM dbo.Drug_Category WHERE dbo.Drug_Category.Name = N'{CategoryComboBox.SelectedItem}')";

                    }
                    else
                    {
                        MessageBox.Show("Error!");
                        flag++;
                    }
                }
                else //if ((!IDCheckBox.Checked && !CategoryCheckBox.Checked) || (IDCheckBox.Checked && CategoryCheckBox.Checked))
                { 
                    res = "row(s) selected";
                    query = "select * from dbo.Scope_Of_Drug_Using join dbo.Drug_Category On Scope_Of_Drug_Using.Category_ID = Drug_Category.Category_ID";
                    //"select * from Scope_Of_Drug_Using as x inner join Drug_Category as y on x.\"Category_ID\" = y.Category_ID";
                    
                    if (int.TryParse(IDTextBox.Text, out id))
                    {
                        query += " where Scope_Of_Drug_Using.Scope_ID = " + IDTextBox.Text;
                    }
                    else if (CategoryComboBox.Text != "")
                    {
                        query += $" where Scope_Of_Drug_Using.Category_ID = (SELECT Drug_Category.Category_ID FROM dbo.Drug_Category WHERE Name = N'{CategoryComboBox.SelectedItem}')";
                    }
                }
            }
            else if (addingCheckBox.Checked)
            {
                if (!InstructionRes.Success && !ScopeRes.Success && !LegalityRes.Success && !RecipeRes.Success && CategoryComboBox.Text != "")
                {
                    res = "1 row(s) inserted";
                    query = "INSERT INTO dbo.Scope_Of_Drug_Using ([Instruction],[Scope_Of_Use],[Recipe],[Legal],[Category_ID]) VALUES (N'" + InstructionTextBox.Text + 
                        "',N'" + ScopeTextBox.Text + "',N'" + RecipeTextBox.Text + "',N'" + LegalityTextBox.Text + "',(select Drug_Category.Category_ID from dbo.Drug_Category where Name = N'" + CategoryComboBox.Text + "'))";
                }
                else
                {
                    MessageBox.Show("Error!");
                    flag++;
                }
            }
            else if (updatingCheckBox.Checked)
            {
                if (!InstructionRes.Success && !ScopeRes.Success && idRes.Success && !LegalityRes.Success && !RecipeRes.Success && CategoryComboBox.Text != "")
                {
                    res = "1 row(s) updated";
                    query = "UPDATE dbo.Scope_Of_Drug_Using SET Instruction = N'" + InstructionTextBox.Text + "', Category_ID = (select Category_ID from dbo.Drug_Category where Name = N'" + CategoryComboBox.Text + "'), " +
                        "Scope_Of_Use = N'" + ScopeTextBox.Text + "', Recipe = N'" + RecipeTextBox.Text + "', Legal = N'" + LegalityTextBox.Text + "' WHERE Scope_ID =" + IDTextBox.Text;
                }
                else
                {
                    MessageBox.Show("Error!");
                    flag++;
                }
            }
            else if (deletingCheckBox.Checked)
            {
                if (idRes.Success)
                {
                    res = "1 row(s) deleted";
                    query = "delete from dbo.Scope_Of_Drug_Using where Scope_ID = " + IDTextBox.Text;
                }
                else
                {
                    MessageBox.Show("Error!");
                    flag++;
                }
            }
            if (flag == 0)
            {
                using (SqlConnection conn = new SqlConnection(DB))
                {
                    conn.Open();
                    SqlDataAdapter adapt = new SqlDataAdapter(query, conn);
                    DataSet data = new DataSet();
                    adapt.Fill(data);
                    dataGridView1.Visible = true;
                    if (gettingCheckBox.Checked)
                    {
                        dataGridView1.DataSource = data.Tables[0];
                        res = res.Insert(0, data.Tables[0].Rows.Count.ToString());
                    }
                    else
                    {
                        adapt = new SqlDataAdapter("select * from dbo.Scope_Of_Drug_Using join dbo.Drug_Category On Scope_Of_Drug_Using.Category_ID = Drug_Category.Category_ID", DB);
                        data = new DataSet();
                        adapt.Fill(data);
                        dataGridView1.DataSource = data.Tables[0];
                        textBoxRes.Text = res;
                    }
                }
                fillCategories();
                IDTextBox.Text = "";
                CategoryComboBox.Text = "";
                LegalityTextBox.Text = "";
                RecipeTextBox.Text = "";
                ScopeTextBox.Text = "";
                InstructionTextBox.Text = "";
            }
        }
    }
}
