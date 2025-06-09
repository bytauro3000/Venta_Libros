using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Venta_Libros.Models
{
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }

        [Display(Name = "Cliente"), Required]
        public int IdCliente { get; set; }

        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }

        [Display(Name = "Total")]
        public decimal? Total { get; set; }

        [Display(Name = "Estado")]
        public string Estado { get; set; }
    }
}