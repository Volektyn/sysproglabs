using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library_3;
using Library_4;

namespace xy
{
    public partial class Iks_And_Igrek : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ResultBox.Enabled = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(double.TryParse(XBox.Text, out double x) && double.TryParse(YBox.Text, out double y))
            {
                XBox.BackColor = System.Drawing.Color.White;
                YBox.BackColor = System.Drawing.Color.White;
                KI3_Class_3 func = new KI3_Class_3();
                ResultBox.Text = KI3_Class_4.F4(x,y).ToString();
            }
            else
            {
                XBox.BackColor = System.Drawing.Color.PaleVioletRed;
                YBox.BackColor = System.Drawing.Color.PaleVioletRed;
            }
        }
    }
}