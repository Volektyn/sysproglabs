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
    public partial class page5 : System.Web.UI.Page
    {
        const string CONNECTION_STRING = @"Data Source = DESKTOP-GMI6RAJ\SQLEXPRESS;Initial Catalog = 5labDB;Integrated Security = True";
        int id;
        string Login, Name, Surname, Email, ImageData;

        protected void Button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            Response.Redirect("page1.aspx");//"~/page1.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {     
                if (Request.UrlReferrer.OriginalString.Contains("page1.aspx") || IsPostBack) //== "http://localhost:64824/page1.aspx")//"~/page1.aspx")
                {
                    string strID = Request.QueryString["id"];
                    int.TryParse(strID, out id);
                    GetData();
                    FillData();
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
            
        void GetData()
        {
            try
            {
                string query = $"select * from dbo.WebUser where ID={id}";
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Login = (string)reader.GetValue(1);
                            Name = (string)reader.GetValue(3);
                            Surname = (string)reader.GetValue(4);
                            Email = (string)reader.GetValue(5);
                            ImageData = (string)reader.GetValue(11);
                            ImageData = ImageData.Remove(0, 48);
                            WriteLog($"ImageURL: {ImageData}");
                        }
                    }
                    else
                    {
                        throw new NoDataException();
                    }
                }
            }
            catch (NoDataException e) { Response.Write(e.Message); }
            catch (Exception e) { Response.Write(e.Message); }
        }

        void FillData()
        {
            Label2.Text = $"{Name} {Surname}";
            Label5.Text = $"{Login}";
            Label6.Text = $"{Email}";
            Image1.ImageUrl = $"{ImageData}";
            WriteLog($"Image1.ImageUrl: {Image1.ImageUrl}");
        }

        void WriteLog(string message)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Valentyn\Desktop\sysprog\5lab\Logs\Logs5.log", true))
            {
                sw.WriteLine($"----------------------|||||||||||||||| {DateTime.Now} |||||||||||||----------------------");
                sw.WriteLine(message);
            }
        }
    }


    public class NoDataException : Exception { }
}
