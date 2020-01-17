using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

namespace _5lab
{
    public partial class page4_error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (!Request.UrlReferrer.OriginalString.Contains("/page3.aspx"))
            {
                Response.Redirect("404.aspx");
            }*/
            try
            {
                if (!Request.UrlReferrer.OriginalString.Contains("page3.aspx") && !IsPostBack)
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
            Thread.Sleep(2000);
            Response.Redirect("page1.aspx");
        }
    }
}