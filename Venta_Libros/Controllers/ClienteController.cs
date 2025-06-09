using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Venta_Libros.DAL;
using Venta_Libros.Models;

namespace Venta_Libros.Controllers
{
    public class ClienteController : Controller
    {
        ClienteDAL cli = new ClienteDAL();

        // GET: Cliente
        public ActionResult Index()
        {
            return View(cli.ListarClientes());
        }
    }
}