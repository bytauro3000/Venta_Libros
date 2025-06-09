using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Venta_Libros.Models
{
    public class DetallePedido
    {
        [Key]
        public int IdDetalle { get; set; }

        [Display(Name = "Pedido")]
        public int? IdPedido { get; set; }

        [Display(Name = "Libro")]
        public int? IdLibro { get; set; }

        [Display(Name = "Cantidad"), Required]
        public int Cantidad { get; set; }

        [Display(Name = "Precio Unitario")]
        public decimal? PrecioUnitario { get; set; }

    }
}