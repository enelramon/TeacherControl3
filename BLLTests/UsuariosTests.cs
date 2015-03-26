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
            usuario.Nombre = "juan";
            usuario.Clave = "juanito";
            usuario.Confirmar = "juanito";
            usuario.Email = "juan@hotmail.com";
            usuario.esActivo = true;
            accion = usuario.Insertar();
            Assert.AreEqual(accion, true, "Inserto");
        }

        [TestMethod()]
        public void ModificarTest()
        {
            usuario.IdUsuario = 3;
            usuario.Nombre = "jose";
            usuario.Clave = "jesus";
            usuario.Confirmar = "jesus";
            usuario.Email = "jose@hotmail.com";
            usuario.esActivo = true;
            accion = usuario.Modificar();
            Assert.AreEqual(accion, true, "Modificado");
        }

        [TestMethod()]
        public void EliminarTest()
        {
            usuario.IdUsuario = 1;
            accion = usuario.Eliminar(1);
            Assert.AreEqual(true, accion);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            usuario.IdUsuario = 2;
   
            accion = usuario.Buscar(2);

            Assert.AreEqual(true, accion);
        }

        [TestMethod()]
        public void ListarTest()
        {

            DataTable Datos = new DataTable();
            Datos = usuario.Listar(" * ", " 1=1 ");

            Assert.AreNotEqual(0, Datos);
        }

        [TestMethod()]
        public void BuscarIdTest()
        {
            usuario.Nombre = "juan";
            accion = usuario.BuscarId(" 1=1 ");

            Assert.AreNotEqual(true, accion);
        }

        [TestMethod()]
        public void AutenticarTest()
        {
            usuario.IdUsuario = 2;
            usuario.Clave = "juanito";
            accion = usuario.Autenticar("  ", "  ");

            Assert.AreNotEqual(true, accion);
        }
    }
}
