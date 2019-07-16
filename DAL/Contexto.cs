using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Vehiculos> Vehiculos { get; set; }
        public DbSet<Proveedores> Proveedores { get; set; }
        public DbSet<OtrosColores> otros { get; set; }
        public DbSet<OtrasMarcas> otrasmarcas { get; set; }
        public DbSet<Ventas> ventas { get; set; }

        public Contexto() : base("ConStr")
        { }
    }
}
