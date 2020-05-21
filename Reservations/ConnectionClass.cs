using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;



namespace Reservations
{
    class ConnectionClass
    {
        
        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        static string databaseName = "reservationDBlocal.mdf";
        SqlConnection conObj = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + ";database=reservationDBlocal;Integrated Security=True;");
        //static string connectionString = ConfigurationManager.ConnectionStrings["Reservations.Properties.Settings.reservationDBlocalConnectionString"].ConnectionString;
        //SqlConnection conObj = new SqlConnection(connectionString);
        //SqlConnection conObj = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename= C:\\Users\\HP\\documents\visual studio 2015\\Projects\\Reservations\\Reservations\reservationDBlocal.mdf;Integrated Security=True");
        SqlCommand cmdObj;
        SqlDataAdapter adpObj;
        DataTable dt = new DataTable();

        public DataTable selectData(string sql)
        {
            DataTable dt1 = new DataTable();
            conObj.Open();
            cmdObj = new SqlCommand(sql, conObj);
            adpObj = new SqlDataAdapter(sql, conObj);
            adpObj.Fill(dt1);
            conObj.Close();
            return dt1;
        }

        
        public bool inserData(string sql)
        {
            conObj.Open();
            try
            {
                cmdObj = new SqlCommand(sql, conObj);
                cmdObj.ExecuteNonQuery();
            }
            catch
            {
                conObj.Close();
                return false;
            }
            conObj.Close();
            return true;
        }
        public int scalar(string sql)
        {
            conObj.Open();
            cmdObj = new SqlCommand(sql, conObj);
            int i = Convert.ToInt32(cmdObj.ExecuteScalar());
            conObj.Close();
            return i;
        }

        public bool manipulateData(string sql)
        {
            conObj.Open();
            try
            {
                cmdObj = new SqlCommand(sql, conObj);
                cmdObj.ExecuteNonQuery();
            }
            catch
            {
                conObj.Close();
                return false;
            }
            conObj.Close();
            return true;
        }
    }
}
