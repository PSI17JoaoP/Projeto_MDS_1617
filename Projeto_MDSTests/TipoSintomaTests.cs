using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto_MDS;

namespace Projeto_MDSTests
{
    [TestClass]
    public class TipoSintomaTests
    {
        [TestMethod]
        public void guardarTipoSintoma()
        {
            TipoSintoma tiposintoma = new TipoSintoma("Teste", "Teste");

            Assert.IsTrue(tiposintoma.guardarTipoSintoma());
        }

        [TestMethod]
        public void alterarTipoSintoma()
        {
            TipoSintoma tiposintoma = new TipoSintoma("Teste", "Teste");

            Assert.IsTrue(tiposintoma.alterarTipoSintoma(57));
        }

        [TestMethod]
        public void eliminarTipoSintoma()
        {
            TipoSintoma tiposintoma = new TipoSintoma("Teste1", "Teste1");

            Assert.IsTrue(tiposintoma.apagarTipoSintoma(65));
        }


    }
}
