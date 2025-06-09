using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Venta_Libros.Models
{
    public class Libro
    {
        [Key]
        public int IdLibro { get; set; }

        [Display(Name = "Título"), Required]
        public string Titulo { get; set; }

        [Display(Name = "Autor")]
        public string Autor { get; set; }

        [Display(Name = "Editorial")]
        public string Editorial { get; set; }

        [Display(Name = "Precio"), Required]
        public decimal Precio { get; set; }

        [Display(Name = "Stock"), Required]
        public int Stock { get; set; }

        [Display(Name = "Categoría")]
        public string Categoria { get; set; }

        [Display(Name = "Fecha de Publicación")]
        public DateTime? FechaPublicacion { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
    }
}