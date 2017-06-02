using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                //int id = 0;
                //Boolean medico = false;
                if(tbxnomeutilizador.Text.Length > 0 && tbxpalavrapasse.Text.Length > 0)
                {
                    string nome = tbxnomeutilizador.Text;
                    string palavrapasse = tbxpalavrapasse.Text;

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    SqlDataReader reader;

                    cmd.CommandText = "SELECT * FROM utilizador u, medico m WHERE u.username = '" + nome + "' AND u.password = '" + palavrapasse + "' AND u.Id = m.id_utilizador";

                    cmd.CommandType = CommandType.Text;

                    reader = cmd.ExecuteReader();

                    //int id = reader.GetOrdinal("Id");
                    //int nomeutilizador = reader.GetOrdinal("username");
                    //int palavrapasse1 = reader.GetOrdinal("password");


                    if (reader.HasRows) { 
                        if (reader.Read())
                        {
                            int id = Convert.ToInt32(reader[0]);
                            //MessageBox.Show(id.ToString());
                            //MessageBox.Show(reader[1].ToString());
                            //MessageBox.Show(reader[2].ToString());



                            Utilizadores utilizador = new Utilizadores(reader[1].ToString(), reader[2].ToString());

                            //MessageBox.Show(utilizador.ToString());

                            /*FormMinhasConsultas form = new FormMinhasConsultas(utilizador, id);
                            form.Show();
                            Hide();*/

                            

                            /*medico = verificaMedico(id);

                            if(medico == true)
                            {*/
                                FormPrincipalMedico form = new FormPrincipalMedico(utilizador, id);
                                form.Show();
                                Hide();
                            /*}
                            else
                            {
                                MessageBox.Show("O utilizador inserido não é médico.");
                            }*/
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("Utilizador inválido.");
                    }
                    
                    //con.Close();
                    //int id1 = reader.GetInt32(id);
                    //string nomeutilizador1 = reader.GetString(1);
                    //string palavrapasse11 = reader.GetString(palavrapasse1);

                    //MessageBox.Show(id1 + " - " + nomeutilizador1 + " - " + palavrapasse11); 







                    
                    
                    //cmd.ExecuteNonQuery();

                    
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
    }
}
