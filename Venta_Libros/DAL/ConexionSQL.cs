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
        public SqlConnection cn = new SqlConnection(
        ConfigurationManager.ConnectionStrings["Libreria"].ConnectionString);
    }
}