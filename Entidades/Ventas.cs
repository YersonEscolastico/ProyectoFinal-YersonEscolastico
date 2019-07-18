using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Ventas
    {
        [Key]
        public int VentaId { get; set; }      
        public DateTime FechaVenta { get; set; }
        public int ClienteId { get; set; }
        public int UsuarioId { get; set; }
        public decimal Total { get; set; }

        public virtual List<VentasDetalle> Vehiculos { get; set; }
        public Ventas()
        {
            VentaId = 0;
            Total = 0;
            FechaVenta = DateTime.Now;
            ClienteId = 0;
            UsuarioId = 0;
            Vehiculos = new List<VentasDetalle>();
        }
        public void CalcularMonto()
        {
            decimal total = 0;

            foreach (var item in Vehiculos)
            {
                total += item.SubTotal;
            }
            Total = total;
        }
    }
}
