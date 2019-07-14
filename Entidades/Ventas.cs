﻿using System;
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
        public decimal Precio { get; set; }      
        public DateTime FechaVenta { get; set; }


        public Ventas()
        {
            VentaId = 0;
            Precio = 0;
            FechaVenta = DateTime.Now;
        }
    }
}
