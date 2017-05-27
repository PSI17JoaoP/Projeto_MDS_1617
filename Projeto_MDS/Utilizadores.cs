using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MDS
{
    public class Utilizadores
    {
        protected string Username { get; set; }
        protected string Password { get; set; }


        protected Utilizadores(string username, string pass)
        {
            Username = username;
            Password = pass;
        }
    }
}
