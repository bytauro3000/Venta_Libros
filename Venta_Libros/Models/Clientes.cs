using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Venta_Libros.Models
{
    public class Clientes
    {
        [Key]
        public int IdCliente { get; set; }

        [Display(Name = "Nombre"), Required]
        public string Nombre { get; set; }

        [Display(Name = "Apellidos"), Required]
        public string Apellidos { get; set; }

        [Display(Name = "Correo"), Required]
        public string Correo { get; set; }

        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        [Display(Name = "Teléfono"), Required]
        public string Telefono { get; set; }

        [Display(Name = "Fecha de Registro")]
        public DateTime FechaRegistro { get; set; }

    }
}