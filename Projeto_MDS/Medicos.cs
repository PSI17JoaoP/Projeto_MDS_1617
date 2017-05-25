using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MDS
{
    public class Medicos : Utilizadores
    {
        public string Nome { get; set; }
        private int niss;
        private string horaEntrada;
        private string horaSaida;
        public string Especialidade { get; set; }
        



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
                if (value.ToString().Length == 9)
                {
                    niss = value;
                }
                else
                {
                    throw new Exception("NISS inválido");
                }
                
            }
        }



        public Medicos(string username, string pass, string nome, string horaentrada, string horasaida, int niss, string especialidade) : base(username, pass)
        {
            Nome = nome;
            HoraEntrada = horaentrada;
            HoraSaida = horasaida;
            Niss = niss;
            Especialidade = especialidade;
        }
    }
}
