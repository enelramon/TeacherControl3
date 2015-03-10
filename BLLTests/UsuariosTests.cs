using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BLL.Tests
{
    [TestClass()]
    public class UsuariosTests
    {
        Usuarios usuario = new Usuarios();
        bool paso = false;

        [TestMethod()]
        public void UsuariosTest()
        {
            usuario.IdUsuario = 0;
        }

        [TestMethod()]
        public void InsertarTest()
        {
            usuario.IdUsuario = Convert.ToInt32(" ");
            usuario.Nombre = "juan";
            usuario.Clave = "juanito";
            usuario.Email = "juan@hotmail.com";
            usuario.esActivo = true;
            paso = usuario.Insertar();

            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            usuario.IdUsuario = ' ';
            usuario.Nombre = "jose";
            usuario.Clave = "jesus";
            usuario.Email = "juan@hotmail.com";
            usuario.esActivo = true;
            paso = usuario.Modificar();

            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            usuario.IdUsuario = ' ';
            usuario.Nombre = "juan";
            usuario.Clave = "juanito";
            usuario.Email = "juan@hotmail.com";
            usuario.esActivo = true;
            paso = usuario.Eliminar(' ');

            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            usuario.IdUsuario = Convert.ToInt32(' ');
            usuario.Nombre = "juan";
            usuario.Clave = "juanito";
            usuario.Email = "juan@hotmail.com";
            usuario.esActivo = true;
            paso = usuario.Buscar(' ');

            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ListarTest()
        {
            usuario.IdUsuario = ' ';
            usuario.Nombre = "juan";
            usuario.Clave = "juanito";
            usuario.Email = "juan@hotmail.com";
            usuario.esActivo = true;
            paso = usuario.Listar(" "," ");

            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarIdTest()
        {
            usuario.IdUsuario = Convert.ToInt32(' ');
            usuario.Nombre = "juan";
            paso = usuario.BuscarId(" ");

            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void AutenticarTest()
        {
            usuario.IdUsuario = Convert.ToInt32(' ');
            usuario.Clave = "juanito";
            paso = usuario.Autenticar(" "," ");

            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void EliminarTest1()
        {
            Assert.Fail();
        }
    }
}
