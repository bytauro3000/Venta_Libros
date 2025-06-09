using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Venta_Libros.DAL
{
    public class ConexionSQL
    {

        private readonly string connectionString = ConfigurationManager.ConnectionStrings["Libreria"].ConnectionString;

        public string ProbarConexion()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    return "✅ Conexión exitosa a la base de datos.";
                }
            }
            catch (Exception ex)
            {
                return "❌ Error al conectar: " + ex.Message;
            }
        }
    }
}