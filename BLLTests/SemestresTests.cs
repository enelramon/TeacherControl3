using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace BLL.Tests
{
    [TestClass()]
    public class SemestresTests
    {
        Semestres semes = new Semestres();

        [TestMethod()]
        public void InsertarTest()
        {
            bool paso = false;


            semes.Codigo = "23";
            semes.FechaInicio = DateTime.Now;
            semes.FechaFin = DateTime.Now;
            semes.FechaParcial1 = DateTime.Now;
            semes.FechaParcial2 = DateTime.Now;
            semes.FechaFinal = DateTime.Now;
            semes.esActivo = true;

            paso = semes.Insertar();
            Assert.AreEqual(true, paso);


        }

        [TestMethod()]
        public void EliminarTest()
        {


        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;


            semes.Codigo = "023";
            semes.FechaInicio = DateTime.Now;
            semes.FechaFin = DateTime.Now;
            semes.FechaParcial1 = DateTime.Now;
            semes.FechaParcial2 = DateTime.Now;
            semes.FechaFinal = DateTime.Now;
            semes.esActivo = true;
            paso = semes.Modificar();
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso = false;
            semes.IdSemestre = 3;

            paso = semes.Buscar();

            Assert.AreEqual(false, paso);
        }

        [TestMethod()]
        public void ListarTest()
        {
            Assert.Fail();
        }
    }
}
