using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MDS
{
    public class Utilizadores
    {
        public string Username { get; set; }
        public string Password { get; set; }


        public Utilizadores(string username, string pass)
        {
            Username = username;
            Password = pass;
        }
    }
}
