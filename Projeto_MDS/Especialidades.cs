using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MDS
{
    public class Especialidades
    {
        private string nome;



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



        public Especialidades(string nome)
        {
            Nome = nome;
        }
    }
}
