using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Venta_Libros.Models
{
    public class Usuario
    {
        private int id {  get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

        public string direccion {  get; set; }
        public string sexo { get; set; }

    }
}