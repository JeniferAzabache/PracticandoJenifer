using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Nestle.WebApplication.Models.DAO
{
    public class ConexionBD
    {
        public static SqlConnection GetConnection()
        {

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