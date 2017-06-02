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
    public class MarcacaoTests
    {
        /// <summary>
        /// É suposto criar
        /// </summary>
        [TestMethod()]
        public void MarcacaoSucesso()
        {
            try
            {
                //
                Pacientes paciente = new Pacientes("Paciente", 910000000, 201000000);
                Especialidades especialidade = new Especialidades("Especialidade");
                Medicos medico = new Medicos("medico", "medico", "Medico", "09:00", "19:00", 201200000, especialidade);
                DateTime data = DateTime.Today.AddDays(1);
                string hora = "10:30";

                //
                Marcacao marcacao = new Marcacao(paciente, data, hora, medico, true);
            }
            catch (Exception)
            {
                Assert.Fail();
                throw;
            }
        }

        /// <summary>
        /// É suposto não criar
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void MarcacaoFalha()
        {
            try
            {
                //
                Pacientes paciente = new Pacientes("Paciente", 910000000, 201000000);
                Especialidades especialidade = new Especialidades("Especialidade");
                Medicos medico = new Medicos("medico", "medico", "Medico", "09:00", "19:00", 201200000, especialidade);
                DateTime data = Convert.ToDateTime("01/01/2017");
                string hora = "10:30";

                //
                Marcacao marcacao = new Marcacao(paciente, data, hora, medico, true);
            }
            catch (Exception)
            {
                throw;
            }

            Assert.Fail();

        }

        //----------------------------------------

        [TestMethod()]
        public void ValidaDataSucesso()
        {
            //
            Pacientes paciente = new Pacientes("Paciente", 910000000, 201000000);
            Especialidades especialidade = new Especialidades("Especialidade");
            Medicos medico = new Medicos("medico", "medico", "Medico", "09:00", "19:00", 201200000, especialidade);
            DateTime data = DateTime.Today.AddDays(1);
            string hora = "10:30";

            Marcacao marcacao = new Marcacao(paciente, data, hora, medico, false);
            

            //
            Assert.IsTrue(marcacao.ValidaData(data));
        }

        [TestMethod()]
        public void ValidaDataFalha()
        {
            //
            Pacientes paciente = new Pacientes("Paciente", 910000000, 201000000);
            Especialidades especialidade = new Especialidades("Especialidade");
            Medicos medico = new Medicos("medico", "medico", "Medico", "09:00", "19:00", 201200000, especialidade);
            DateTime data = Convert.ToDateTime("01/01/2017");
            string hora = "10:30";

            Marcacao marcacao = new Marcacao(paciente, data, hora, medico, false);


            //
            Assert.IsFalse(marcacao.ValidaData(data));
        }

        //----------------------------------------

        [TestMethod()]
        public void ValidaHoraSucesso()
        {
            //
            Pacientes paciente = new Pacientes("Paciente", 910000000, 201000000);
            Especialidades especialidade = new Especialidades("Especialidade");
            Medicos medico = new Medicos("medico", "medico", "Medico", "09:00", "19:00", 201200000, especialidade);
            DateTime data = DateTime.Today.AddDays(1);
            string hora = "10:30";

            Marcacao marcacao = new Marcacao(paciente, data, hora, medico, false);


            //
            Assert.IsTrue(marcacao.ValidaHora(hora));
        }

        [TestMethod()]
        public void ValidaHoraFalha()
        {
            //
            Pacientes paciente = new Pacientes("Paciente", 910000000, 201000000);
            Especialidades especialidade = new Especialidades("Especialidade");
            Medicos medico = new Medicos("medico", "medico", "Medico", "09:00", "19:00", 201200000, especialidade);
            DateTime data = DateTime.Today.AddDays(1);
            string hora = "99:66";

            Marcacao marcacao = new Marcacao(paciente, data, hora, medico, false);


            //
            Assert.IsFalse(marcacao.ValidaHora(hora));
        }

        //----------------------------------------

        [TestMethod()]
        public void VerificarDisponibilidadeMedicaTest()
        {
            Pacientes paciente = new Pacientes("Paciente", 910000000, 201000000);
            Especialidades especialidade = new Especialidades("Especialidade");
            Medicos medico = new Medicos("medico", "medico", "Medico", "09:00", "19:00", 201200000, especialidade);
            DateTime data = DateTime.Today.AddDays(1);
            string hora = "10:30";

            Marcacao marcacao = new Marcacao(paciente, data, hora, medico, false);

            //Já tem consulta
            Assert.IsTrue(marcacao.VerificarDisponibilidadeMedica(medico.Nome, data.ToShortDateString(), hora));

            //Não tem consulta
            Assert.IsFalse(marcacao.VerificarDisponibilidadeMedica(medico.Nome, data.ToShortDateString(), "10:00"));
        }
    }
}