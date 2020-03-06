using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConsolaTestBD
{
    public class ConexionBD
    {
        public static SqlConnection GetConnection()
        {
            //string cadena = @"Data Source=LAPTOP-K39MRIPD\MSSQLSERVER_HQ; DATABASE=Nestle; Trusted_Connection=true; INTEGRATED SECURITY=true;";
            string cadena = ConfigurationManager.ConnectionStrings["connBD"].ConnectionString;
            SqlConnection connection = new SqlConnection(cadena);

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            else
            {
                connection.Open();
            }

            return connection;
        }
    }
}
