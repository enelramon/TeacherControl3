using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace BLL.Tests
{
    [TestClass()]
    public class UsuariosTests
    {
        Usuarios usuario = new Usuarios();
        bool accion = false;
        [TestMethod()]
        public void UsuariosTest()
        {

        }

        [TestMethod()]
        public void InsertarTest()
        {
            usuario.IdUsuario = Convert.ToInt32(" ");
            usuario.Nombre = "juan";
            usuario.Clave = "juanito";
            usuario.Email = "juan@hotmail.com";
            usuario.esActivo = true;
            accion = usuario.Insertar();
            Assert.AreEqual(accion, true, "Inserto");
        }

        [TestMethod()]
        public void ModificarTest()
        {
            usuario.IdUsuario = Convert.ToInt32(" ");
            usuario.Nombre = "jose";
            usuario.Clave = "jesus";
            usuario.Email = "juan@hotmail.com";
            usuario.esActivo = true;
            accion = usuario.Modificar();

            Assert.AreEqual(true, accion);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            usuario.IdUsuario = Convert.ToInt32(" ");
            usuario.Nombre = "juan";
            usuario.Clave = "juanito";
            usuario.Email = "juan@hotmail.com";
            usuario.esActivo = true;
            accion = usuario.Eliminar(' ');

            Assert.AreEqual(true, accion);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            usuario.IdUsuario = Convert.ToInt32(" ");
            usuario.Nombre = "juan";
            usuario.Clave = "juanito";
            usuario.Email = "juan@hotmail.com";
            usuario.esActivo = true;
            accion = usuario.Buscar(' ');

            Assert.AreEqual(true, accion);
        }

        [TestMethod()]
        public void ListarTest()
        {
            usuario.IdUsuario = Convert.ToInt32(" ");
            usuario.Nombre = "juan";
            usuario.Clave = "juanito";
            usuario.Email = "juan@hotmail.com";
            usuario.esActivo = true;
            accion = usuario.Listar(" ", " ");

            Assert.AreEqual(true, accion);
        }

        [TestMethod()]
        public void BuscarIdTest()
        {
            usuario.IdUsuario = Convert.ToInt32(" ");
            usuario.Nombre = "juan";
            accion = usuario.BuscarId(" ");

            Assert.AreEqual(true, accion);
        }

        [TestMethod()]
        public void AutenticarTest()
        {
            usuario.IdUsuario = Convert.ToInt32(" ");
            usuario.Clave = "juanito";
            accion = usuario.Autenticar(" ", " ");

            Assert.AreEqual(true, accion);
        }

        [TestMethod()]
        public void EliminarTest1()
        {
            Assert.Fail();
        }
    }
}
