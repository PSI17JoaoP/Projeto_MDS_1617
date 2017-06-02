using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            Password = HashPassword(pass);
        }

        private string HashPassword(string password)
        {
            string passwordHash;

            using (SHA512 sha512Algorithm = new SHA512CryptoServiceProvider())
            {
                byte[] dadosBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha512Algorithm.ComputeHash(dadosBytes);

                passwordHash = BitConverter.ToString(hashBytes);
            }

            return passwordHash;
        }
    }
}
