using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_MDS
{
    public partial class FormLogin : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.connectionString);
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(tbxnomeutilizador.Text.Length > 0 && tbxpalavrapasse.Text.Length > 0)
                {
                    string nome = tbxnomeutilizador.Text.Trim();
                    string palavrapasse = HashPassword(tbxpalavrapasse.Text);

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    SqlDataReader reader;

                    cmd.CommandText = "SELECT * FROM utilizador u, medico m WHERE u.username = '" + nome + "' AND u.password = '" + palavrapasse + "' AND u.Id = m.id_utilizador";

                    cmd.CommandType = CommandType.Text;

                    reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {

                        if (reader.Read())
                        {
                            int id = Convert.ToInt32(reader[0]);

                            Utilizadores utilizador = new Utilizadores(reader[1].ToString(), reader[2].ToString());

                            FormPrincipalMedico form = new FormPrincipalMedico(utilizador, id);
                            form.Show();
                            Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Utilizador inválido.");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha os dados corretamente", "Preenchimento de dados");
                }
                
                con.Close();
            }
        }

        private Boolean verificaMedico(int idutilizador)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader reader;
            Boolean medico = false;
            cmd.CommandText = "SELECT * FROM medico WHERE id_utilizador = " + idutilizador;
            cmd.CommandType = CommandType.Text;

            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show("Olá");
                if (reader.Read())
                {
                    int idutilizador1 = Convert.ToInt32(reader[0]);
                    medico = true;
                }
            }
            con.Close();
            return medico;
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

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMenu form = new FormMenu();
            form.Show();
            Hide();
        }
    }
}
