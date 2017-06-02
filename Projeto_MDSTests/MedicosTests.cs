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
        public void Adicionar()
        {
            Medicos medico = new Medicos("testeAdicionar", "testeAdicionar", "Este Médico", "10:00", "11:00", 981444444, new Especialidades("Geral"));

            Assert.IsTrue(medico.Adicionar());
        }

        [TestMethod()]
        public void VerificarDadosMedico()
        {
            Medicos medico = new Medicos("testeVerificar", "testeVerificar", "Este Médico", "10:00", "11:00", 128574655, new Especialidades("Geral"));

            Assert.IsTrue(medico.VerificarDadosMedico());
        }
    }
}