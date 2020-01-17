using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Threading;

namespace _5lab
{
    public partial class page1 : System.Web.UI.Page
    {
        const string CONNECTION_STRING = @"Data Source = DESKTOP-GMI6RAJ\SQLEXPRESS;Initial Catalog = 5labDB;Integrated Security = True";
        
        int userID;

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = $"select ID from dbo.WebUser where Login='{TextBox1.Text}' and Password='{TextBox2.Text}'";
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader =  command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        userID = (int)reader.GetValue(0);
                    }
                    //Session["id"] = userID;
                    /*Login = (string)reader.GetValue(1);
                    Name = (string)reader.GetValue(3);
                    Surname = (string)reader.GetValue(4);
                    Email = (string)reader.GetValue(5);
                    ImageData = (byte[])reader.GetValue(11);*/

                    Thread.Sleep(2000);

                    Response.Redirect($"page5.aspx?id={userID.ToString()}");
                }
                else
                {
                    if (TextBox1.Text == "")
                        TextBox1.BackColor = System.Drawing.Color.MistyRose;
                    if (TextBox2.Text == "")
                        TextBox2.BackColor = System.Drawing.Color.MistyRose;
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            Response.Redirect("page2.aspx");
        }
    }
}