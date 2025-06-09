using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Venta_Libros.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Display(Name = "Nombre"), Required]
        public string Nombre { get; set; }

        [Display(Name = "Apellidos"), Required]
        public string Apellidos { get; set; }

        [Display(Name = "Correo"), Required]
        public string Correo { get; set; }

        [Display(Name = "Contraseña"), Required]
        public string Contraseña { get; set; }

        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [Display(Name = "Rol")]
        public string Rol { get; set; }

    }
}