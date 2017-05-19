using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MDS
{
    public class Pacientes
    {
        private string nome;
        private int telefone;
        private int niss;



        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public int Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
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




        public Pacientes(string nome, int telefone, int niss)
        {
            Nome = nome;
            Telefone = telefone;
            Niss = niss;
        }
    }
}
