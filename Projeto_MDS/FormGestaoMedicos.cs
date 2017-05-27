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
    public partial class FormGestaoMedicos : Form
    {
        private FormMenu formMenu;

        public FormGestaoMedicos(FormMenu form)
        {
            InitializeComponent();

            formMenu = form;
        }

        private void FormGestaoMedicos_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    string queryString = "SELECT * from medico";

                    using (SqlCommand querySql = new SqlCommand(queryString, connection))
                    {
                        connection.Open();

                        using (SqlDataReader queryReader = querySql.ExecuteReader())
                        {
                            if (queryReader.HasRows)
                            {
                                while (queryReader.Read())
                                {
                                    ListViewItem listViewRowMedico = new ListViewItem(queryReader["nome"].ToString());
                                    listViewRowMedico.SubItems.Add(GetEspecialidadeNome(queryReader["id_especialidade"].ToString()));
                                    listViewRowMedico.SubItems.Add(queryReader["niss"].ToString());
                                    listViewRowMedico.SubItems.Add(queryReader["hora_entrada"].ToString());
                                    listViewRowMedico.SubItems.Add(queryReader["hora_saida"].ToString());
                                    lvListaMedicos.Items.Add(listViewRowMedico);
                                }
                            }
                        }

                        connection.Close();
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no carregamento dos médicos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotaoAdicionarMedico(object sender, EventArgs e)
        {
            FormAdicionarMedico formAdicionarMedico = new FormAdicionarMedico(this);
            formAdicionarMedico.Show();
            Hide();
        }

        private void BotaoVoltarPrincipal(object sender, EventArgs e)
        {
            formMenu.Show();
            Hide();
        }

        private string GetEspecialidadeNome(string id)
        {
            string nomeEspecialidade = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    string queryString = "SELECT nome FROM especialidade WHERE Id = @idEspecialidade";

                    using (SqlCommand querySql = new SqlCommand(queryString, connection))
                    {
                        SqlParameter idSQL = new SqlParameter("@idEspecialidade", id);
                        querySql.Parameters.Add(idSQL);

                        connection.Open();

                        using (SqlDataReader queryReader = querySql.ExecuteReader())
                        {
                            if (queryReader.HasRows)
                            {
                                queryReader.Read();
                                nomeEspecialidade = queryReader["nome"].ToString();
                            }
                        }

                        connection.Close();
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no pedido à base de dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return nomeEspecialidade;
        }
    }
}
