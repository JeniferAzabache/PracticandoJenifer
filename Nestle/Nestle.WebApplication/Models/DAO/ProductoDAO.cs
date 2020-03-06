using Nestle.WebApplication.Models.BEAN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Nestle.WebApplication.Models.DAO
{
    public class ProductoDAO
    {
        public List<ProductoBEAN> listaProducto()
        {
            List<ProductoBEAN> lista = new List<ProductoBEAN>();
            SqlCommand cmd = new SqlCommand();
            ProductoBEAN proBEAN;
            SqlDataReader lector;
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Producto_List";
                cmd.Connection = ConexionBD.GetConnection();
                lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    proBEAN = new ProductoBEAN();
                    proBEAN.IdProducto = lector.GetInt32(0);
                    proBEAN.NombreProducto = lector.GetString(1);
                    proBEAN.PrecioProducto = lector.GetString(2);
                   
                    lista.Add(proBEAN);

                }

            }
            catch (Exception)
            {

                throw;
            }

            return lista;

        }
    }
}