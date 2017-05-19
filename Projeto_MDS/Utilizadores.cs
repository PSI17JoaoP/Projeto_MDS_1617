using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MDS
{
    public class Utilizadores
    {
        private string nome;
        private string password;



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

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }



        public Utilizadores(string nome, string pass)
        {
            Nome = nome;
            Password = pass;
        }
    }
}
