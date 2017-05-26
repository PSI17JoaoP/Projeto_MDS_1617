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
        public string HoraEntrada { get; set; }
        public string HoraSaida { get; set; }
        public string Especialidade { get; set; }

        private int _niss;

        public Medicos(string username, string pass, string nome, string horaentrada, string horasaida, int niss, string especialidade) : base(username, pass)
        {
            Nome = nome;
            HoraEntrada = horaentrada;
            HoraSaida = horasaida;
            Niss = niss;
            Especialidade = especialidade;
        }

        public int Niss
        {
            get{ return _niss; }

            set
            {
                if (value.ToString().Length == 9)
                {
                    _niss = value;
                }

                else
                {
                    throw new Exception("NISS inválido");
                }
            }
        }
    }
}
