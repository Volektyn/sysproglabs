using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Threading;

namespace _5lab
{
    public partial class page2 : System.Web.UI.Page
    {
        //GET DATA FROM DROPLISTS!!
        const string CONNECTION_STRING = @"Data Source = DESKTOP-GMI6RAJ\SQLEXPRESS;Initial Catalog = 5labDB;Integrated Security = True";
        string Name, Surname, Login, Email, Password, Role, Rank, Curse, Faculty, StructUnit, Image;

        protected void Button2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            Response.Redirect("page1.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.Enabled = false;
            DropDownList3.Enabled = false;
            try
            {
                if (Request.UrlReferrer.OriginalString.Contains("page1.aspx") || Request.UrlReferrer.OriginalString.Contains("page3.aspx") || IsPostBack)
                {
                    DropDownList1.Enabled = false;
                }
                else
                {
                    Response.Redirect("404.aspx");
                }
            }
            catch
            {
                Response.Redirect("404.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try {
                Role = RadioButtonList1.SelectedValue;
                if (TextBox1.Text != string.Empty && TextBox2.Text != string.Empty && TextBox3.Text != string.Empty
                    && TextBox4.Text != string.Empty && TextBox5.Text != string.Empty && FileUpload1.HasFile && UploadImage())
                {
                    Name = TextBox1.Text;
                    Surname = TextBox2.Text;
                    Login = TextBox3.Text;
                    Email = TextBox4.Text;
                    Password = TextBox5.Text;
                    Role = RadioButtonList1.SelectedValue;

                    if (Role == "Студент")
                    {
                        Curse = DropDownList1.Text;
                        Faculty = DropDownList2.Text;
                        StructUnit = "";
                    }
                    else if (Role == "Викладач")
                    {
                        Curse = "";
                        Faculty = DropDownList2.Text;
                        StructUnit = "";
                    }
                    else if (Role == "Навчально-допоміжний персонал")
                    {
                        Curse = "";
                        Faculty = "";
                        StructUnit = DropDownList3.Text;
                    }

                    if (CheckBox1.Checked)
                        Rank = CheckBox1.Text;
                    else if (CheckBox2.Checked)
                        Rank = CheckBox2.Text;
                    else if (CheckBox3.Checked)
                        Rank = CheckBox3.Text;

                    
                    UploadDataToDB();

                    GenerateAuthorizationCode();

                    Thread.Sleep(2000);
                    Response.Redirect($"page3.aspx?email={Email}");
                }
                else if (TextBox1.Text == string.Empty)
                    TextBox1.BackColor = System.Drawing.Color.MistyRose;
                else if (TextBox2.Text == string.Empty)
                    TextBox2.BackColor = System.Drawing.Color.MistyRose;
                else if (TextBox3.Text == string.Empty)
                    TextBox3.BackColor = System.Drawing.Color.MistyRose;
                else if (TextBox4.Text == string.Empty)
                    TextBox4.BackColor = System.Drawing.Color.MistyRose;
                else if (TextBox5.Text == string.Empty)
                    TextBox5.BackColor = System.Drawing.Color.MistyRose;
                else if (!FileUpload1.HasFile)
                    Response.Write("ОБЕРІТЬ ФОТО");
            }
            catch(Exception ex) { WriteLog(ex.Message); }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedIndex == 0) //for student
            {
                CheckBox2.Enabled = false;
                CheckBox3.Enabled = false;
                DropDownList1.Enabled = true;
                DropDownList2.Enabled = true;
                DropDownList3.Enabled = false;
                CheckBox2.Checked = false;
                CheckBox3.Checked = false;
            }
            else if (RadioButtonList1.SelectedIndex == 1) //for lecturer 
            {
                CheckBox2.Enabled = true; // PhD
                CheckBox3.Enabled = true; // Doctor
                DropDownList1.Enabled = false;
                DropDownList2.Enabled = true;
                DropDownList3.Enabled = false;
            }
            else if (RadioButtonList1.SelectedIndex == 2) //for personal
            {
                CheckBox2.Enabled = true;
                CheckBox3.Enabled = false;
                DropDownList1.Enabled = false;
                DropDownList2.Enabled = false;
                DropDownList3.Enabled = true;
                CheckBox3.Checked = false;
            }

            //Role = RadioButtonList1.SelectedValue;
        }

        void UploadDataToDB()
        {
            string query = $"insert into dbo.WebUser ([Name],[Surname],[Login],[Email],[Password],[Role],[Rank],[Curse],[Faculty],[StructUnit]," +
                $"[ImageName]) values ('{Name}','{Surname}','{Login}','{Email}','{Password}','{Role}','{Rank}','{Curse}','{Faculty}','{StructUnit}','{Image}')";
            using(SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                WriteLog(query);
                command.ExecuteNonQuery();
            }
        }

        bool UploadImage()
        {
            string savePath = @"C:\Users\Valentyn\Desktop\sysprog\5lab\5lab\5lab\Images\";

            if (FileUpload1.HasFile)
            {
                string fileName = FileUpload1.FileName;
                //WriteLog("FILENAME: " + fileName);
                //string extension = Path.GetExtension(fileName);

                //if ((extension == ".png") || (extension == ".jpeg"))
                if (fileName.EndsWith(".png") || fileName.EndsWith(".jpg"))
                {
                    savePath += fileName;
                    //WriteLog(savePath);
                    FileUpload1.SaveAs(savePath);
                    if (CheckSize(savePath))
                    {
                        Image = savePath;
                        return true;
                    }
                    else
                    {
                        Response.Write("Дозволені розміри фото min 100x150, max 200x300");
                        File.Delete(savePath);
                    }
                }
                else
                {
                    Response.Write("ДОЗВОЛЕНИЙ ФОРМАТ ФАЙЛА .jpeg/.png");
                } 
            }
            else
            {
                WriteLog("NO FILE!!!");
            }
            return false;
        }

        bool CheckSize(string path)
        {
            using(System.Drawing.Image objImg = System.Drawing.Image.FromFile(path))
            {
                int width = objImg.Width;
                int height = objImg.Height;

                if (width >= 100 && width <= 200 && height >= 150 && height <= 300)
                    return true;
            }
            return false;
        }

        void WriteLog(string message)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Valentyn\Desktop\sysprog\5lab\Logs\Logs5.log", true))
            {
                sw.WriteLine($"----------------------|||||||||||||||| {DateTime.Now} |||||||||||||----------------------");
                sw.WriteLine(message);
            }
        }

        void GenerateAuthorizationCode()
        {
            Random rnd = new Random();
            Session["authorization code"] = rnd.Next(100000, 999999);
            WriteLog($"Page2 auth: {Session["authorization code"]}");
        }
    }
}