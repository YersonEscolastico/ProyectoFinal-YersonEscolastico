using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RepositorioVentas
    {
        public static bool Guardar(Ventas ventas)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                RepositorioBase<Clientes> cl = new RepositorioBase<Clientes>();

                if (db.ventas.Add(ventas) != null)
                {
                    var cliente = cl.Buscar(ventas.ClienteId);

                    ventas.CalcularMonto();
                    paso = db.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(Ventas ventas)
        {
            bool paso = false;
            Contexto db = new Contexto();
            RepositorioBase<Ventas> cl = new RepositorioBase<Ventas>();

            try
            {
                var cliente = cl.Buscar(ventas.ClienteId);
                var anterior = new RepositorioBase<Ventas>().Buscar(ventas.VentaId);
               
                foreach (var item in anterior.Vehiculos)
                {
                    if (!ventas.Vehiculos.Any(A => A.VentasDetalleID == item.VentasDetalleID))
                    {
                        db.Entry(item).State = EntityState.Deleted;

                    }
                }
                foreach (var item in ventas.Vehiculos)
                {
                    if (item.VentasDetalleID == 0)
                    {
                        db.Entry(item).State = EntityState.Added;
                    }
                    else
                    {
                        db.Entry(item).State = EntityState.Modified;
                    }
                }

                ventas.CalcularMonto();

                db.Entry(ventas).State = EntityState.Modified;

                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static Ventas Buscar(int id)
        {
            Ventas entity;
            Contexto db = new Contexto();

            try
            {
                entity = db.Set<Ventas>().Find(id);

                if (entity != null)
                {
                    entity.Vehiculos.Count();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return entity;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            RepositorioBase<Clientes> cl = new RepositorioBase<Clientes>();
            try
            {
                var Ventas = db.ventas.Find(id);
                var clientes = cl.Buscar(Ventas.VentaId);
                db.Entry(Ventas).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
    }
}
