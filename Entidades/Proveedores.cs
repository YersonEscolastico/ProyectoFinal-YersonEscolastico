using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proveedores
    {
        [Key]
       public int ProveedorId { get; set; }
       public string Nombres { get; set; }
       public string Telefono { get; set; }
       public string Celular { get; set; }
       public string Email { get; set; }
       public string Direccion { get; set; }
       public DateTime FechaRegistro { get; set; }

        public Proveedores()
        {
            ProveedorId = 0;
            Nombres = string.Empty;
            Telefono = string.Empty;
            Celular = string.Empty;
            Email = string.Empty;
            Direccion = string.Empty;
            FechaRegistro = DateTime.Now;
        }
    }   
}
