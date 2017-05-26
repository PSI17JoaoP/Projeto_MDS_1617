using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MDS
{
    public class Pacientes
    {
        public string Nome { get; set; }

        private int _telefone;
        private int _niss;

        public Pacientes(string nome, int telefone, int niss)
        {
            Nome = nome;
            Telefone = telefone;
            Niss = niss;
        }

        public int Telefone
        {
            get
            {
                return _telefone;
            }

            set
            {
                if (value.ToString().Length == 9)
                {
                    _telefone = value;
                }
            }
        }

        public int Niss
        {
            get
            {
                return _niss;
            }

            set
            {
                if (value.ToString().Length == 9)
                {
                    _niss = value;
                }
            }
        }
    }
}
