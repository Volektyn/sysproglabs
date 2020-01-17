using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;
using System.IO;
using System.Threading;

namespace _5lab
{
    public partial class page3 : System.Web.UI.Page
    {
        const string CONNECTION_STRING = @"Data Source = DESKTOP-GMI6RAJ\SQLEXPRESS;Initial Catalog = 5labDB;Integrated Security = True";
        int authCode;
        string email;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.UrlReferrer.OriginalString.Contains("page2.aspx") || IsPostBack)
                {
                    email = Request.QueryString["email"];
                    if (Session["authorization code"] != null)
                        authCode = (int)Session["authorization code"];
                    SendCode(authCode);
                    //Button1.Enabled = false;
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
            WriteLog($"AUTHCODE:{authCode}\nINPUT:{int.Parse(TextBox1.Text)}");
            if(int.Parse(TextBox1.Text) == authCode)
            {
                Thread.Sleep(2000);
                Response.Redirect("page4_success.aspx");
            }
            else
            {
                DeleteRecord();
                Thread.Sleep(2000);
                Response.Redirect("page4_error.aspx");
            }
        }

        void SendCode(int code)
        {
            string from = "valentain.sav99@gmail.com";
            string password = "E3wcWFXqMN";
            try
            {
                using (SmtpClient C = new SmtpClient("smtp.gmail.com"))
                {
                    C.Port = 587;
                    C.Credentials = new NetworkCredential(from, password);
                    C.EnableSsl = true;
                    string bodyMes = code.ToString();
                    C.Send(new MailMessage(from, email, "Код підтвердження", bodyMes));
                }
            }
            catch (Exception e) { WriteLog(e.Message); }
        }

        void DeleteRecord()
        { 
            string query = "delete from dbo.WebUser where WebUser.ID = (IDENT_CURRENT('WebUser'))"; //delete last added ID
            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Button1.Enabled = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            Response.Redirect("page2.aspx");
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
}