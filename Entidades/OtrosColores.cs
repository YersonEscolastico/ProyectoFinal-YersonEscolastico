using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OtrosColores
    {
        [Key]
        public int UbicacionId { get; set; }
        public string Descripcion { get; set; }

        public OtrosColores()
        {
            UbicacionId = 0;
            Descripcion = string.Empty;
        }
    }
}
