using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Otros
    {
        [Key]
        public int UbicacionId { get; set; }
        public string Descripcion { get; set; }

        public Otros()
        {
            UbicacionId = 0;
            Descripcion = string.Empty;
        }
    }
}
