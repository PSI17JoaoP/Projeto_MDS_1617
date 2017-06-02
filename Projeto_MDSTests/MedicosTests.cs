using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto_MDS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MDS.Tests
{
    [TestClass()]
    public class MedicosTests
    {
        [TestMethod()]
        public void MedicosTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void Adicionar()
        {
            Medicos medico = new Medicos("teste", "teste", "Este Médico", "10:00", "11:00", 981444444, new Especialidades("Geral"));

            Assert.IsTrue(medico.Adicionar());

            /*if(medico.Adicionar() == false)
            {
                Assert.Fail();
            }*/
        }

        [TestMethod()]
        public void VerificarDadosMedico()
        {
            Assert.Fail();
        }
    }
}