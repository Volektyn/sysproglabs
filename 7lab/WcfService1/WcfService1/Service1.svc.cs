using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using Library_4;
using System.IO;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        string DB = @"Data Source=DESKTOP-GMI6RAJ\SQLEXPRESS;Initial Catalog=Apteka;Integrated Security=True";

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string F4_WebService(double x)
        {
            return KI3_Class_4.F4(x, 3).ToString();
        }

        public System.Data.DataTable GetAllElements()
        {
            System.Data.DataTable dt = new System.Data.DataTable("Scope");
            SqlConnection Connection = new SqlConnection(DB);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [dbo].[Scope_Of_Drug_Using]", Connection);
            dataAdapter.Fill(dt);
            return dt;
        }

        void WriteLog(string mes)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Valentyn\Desktop\sysprog\logies.log"))
            {
                sw.WriteLine(mes);
            }
        }

        public System.Data.DataTable GetElementByID(int ID)
        {
            System.Data.DataTable dt = new System.Data.DataTable("Scope");
            SqlConnection Connection = new SqlConnection(DB);
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM [dbo].[Scope_Of_Drug_Using] WHERE Scope_ID = {ID}", Connection);
            dataAdapter.Fill(dt);
            return dt;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
