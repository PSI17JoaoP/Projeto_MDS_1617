using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MDS
{
    public class Medicos : Utilizadores
    {
        private string horaEntrada;
        private string horaSaida;
        private int niss;



        public string HoraEntrada
        {
            get
            {
                return horaEntrada;
            }

            set
            {
                horaEntrada = value;
            }
        }

        public string HoraSaida
        {
            get
            {
                return horaSaida;
            }

            set
            {
                horaSaida = value;
            }
        }

        public int Niss
        {
            get
            {
                return niss;
            }

            set
            {
                niss = value;
            }
        }



        public Medicos(string nome, string pass, string horaentrada, string horasaida, int niss) : base(nome, pass)
        {
            HoraEntrada = horaentrada;
            HoraSaida = horasaida;
            Niss = niss;
        }
    }
}
