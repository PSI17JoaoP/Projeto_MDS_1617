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
    public class ConsultaTests
    {
        /// <summary>
        /// Deverá funcionar corretamente
        /// </summary>
        [TestMethod()]
        public void ConsultaCriadaSucesso()
        {
            try
            {
                Consulta consulta = new Consulta(1, 1, "Descrição de Tipo de Sintoma", "MedicamentosTratamentos");
            }
            catch (Exception)
            {
                Assert.Fail();
            }
            
        }

        [TestMethod()]
        public void guardarConsulta()
        {
           //Atenção - Pode ocorrer erro duplicação de chave primária.Uma marcação, só pode ter 1 consulta associada.
            Consulta consulta = new Consulta(1, 30, "Teste", "Teste");
            

            Assert.IsTrue(consulta.guardarConsulta());
        }

        [TestMethod()]
        public void alterarConsulta()
        {
            //Atenção - Pode ocorrer erro duplicação de chave primária.Uma marcação, só pode ter 1 consulta associada.
            Consulta consulta = new Consulta(1, 30, "Teste", "Teste");


            Assert.IsTrue(consulta.alterarConsulta(30));
        }

        [TestMethod()]
        public void getIdTipoSintoma()
        {
            Consulta consulta = new Consulta(1, 30, "Teste", "Teste");

            var id = consulta.getIdTipoSintoma("1");

            if(id == -1)
            {
                Assert.Fail();
            }
        }

    }
}