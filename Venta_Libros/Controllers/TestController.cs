using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Venta_Libros.DAL;

namespace Venta_Libros.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Conexion()
        {
            ConexionSQL conexion = new ConexionSQL();
            string resultado = conexion.ProbarConexion();
            return Content(resultado);
        }
    }
}