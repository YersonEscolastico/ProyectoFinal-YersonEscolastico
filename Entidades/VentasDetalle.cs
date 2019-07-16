using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VentasDetalle
    {   
        public int VentasDetalleID { get; set; }
        public int VentaId { get; set; }
        public int VehiculoId{ get; set; }
        public int Precio { get; set; }
        public decimal SubTotal { get; set; }

        public VentasDetalle()
        {
            VentasDetalleID = 0;
            VentaId = 0;
            VehiculoId = 0;
            Precio = 0;
            SubTotal = 0;
        }

        public VentasDetalle(int ventasDetalleID, int ventaId, int vehiculoId, int precio,decimal subtotal)
        {
            VentasDetalleID = ventasDetalleID;
            VentaId = ventaId;
            VehiculoId = vehiculoId;
            Precio = precio;
            SubTotal = subtotal;
        }
    }
}
