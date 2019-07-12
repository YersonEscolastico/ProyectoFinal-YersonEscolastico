using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace BLL.Tests
{
    [TestClass()]
    public class UsuarioTest
    {
        [TestMethod()]
        public void RepositorioBaseTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();


            Usuarios us = new Usuarios()
            {
            UsuarioId = 0,
            Nombre = "Juan",
            Email = "Juan@gmail.com",
            Usuario = "Juan123",
            Clave = "123",
            NivelAcceso = "123",
            Fecha = DateTime.Now
        };
            Assert.IsTrue(db.Guardar(us));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();

            Usuarios us = new Usuarios()
            {
                UsuarioId = 0,
                Nombre = "Juann",
                Email = "Juan@gmail.com",
                Usuario = "Juan123",
                Clave = "123",
                NivelAcceso = "123",
                Fecha = DateTime.Now
            };

            Assert.IsTrue(db.Modificar(us));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();

            Assert.IsNotNull(db.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();

            Assert.IsNotNull(db.GetList(t => true));
        }


        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();

            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void DuplicadoTest()
        {
            Assert.Fail();
        }
    }
}