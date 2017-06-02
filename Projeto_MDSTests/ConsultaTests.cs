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
        [TestMethod()]
        public void guardarConsulta()
        {
            //Atenção - Pode ocorrer erro duplicação de chave primária.Uma marcação, só pode ter 1 consulta associada.
            Consulta consulta = new Consulta(52, 4, "Teste", "Teste");


            Assert.IsTrue(consulta.guardarConsulta());
        }

        [TestMethod()]
        public void alterarConsulta()
        {
            //Atenção - Pode ocorrer erro duplicação de chave primária.Uma marcação, só pode ter 1 consulta associada.
            Consulta consulta = new Consulta(52, 4, "Teste", "Teste");


            Assert.IsTrue(consulta.alterarConsulta(4));
        }

        [TestMethod()]
        public void devolverIdTipoSintoma()
        {
            Consulta consulta = new Consulta(52, 4, "Teste", "Teste");

            //inserir tipo sintoma teste
            int id = consulta.getIdTipoSintoma("Dores de garganta");

            if (id == -1)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void devolverListaTiposSintomas()
        {
            Consulta consulta = new Consulta(52, 4, "Teste", "Teste");

            List<TipoSintoma> listatipossintomas = consulta.carregarTiposSintomas();

            if (listatipossintomas == null)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void devolverNomeTipoSintoma()
        {
            Consulta consulta = new Consulta(52, 4, "Teste", "Teste");

            string nome = consulta.getNomeTipoSintoma(52);

            if (nome == null)
            {
                Assert.Fail();
            }
        }
    }
}