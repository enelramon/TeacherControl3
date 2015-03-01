using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace BLL.Tests
{
    [TestClass()]
    public class AsignaturasTests
    {
        [TestMethod()]
        public void AsignaturasTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AsignaturasTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InsertarTest()
        {
            bool paso = false;

            Asignaturas asignatura = new Asignaturas(0, "el nombre", 5, true);

            paso = asignatura.Insertar();

            Assert.AreEqual(paso, true, "Inserto" + asignatura.IdAsignatura );
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }
    }
}
