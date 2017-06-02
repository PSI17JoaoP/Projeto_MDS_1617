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
        /// <summary>
        /// Evento do Load do Form. Executa uma query para ir buscar à base de dados, todos os médicos registados.
        /// </summary>
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

        /// <summary>
        /// Botão de Adicionar Médico. Mostra o form para inserção de dados.
        /// </summary>
        private void BotaoAdicionarMedico(object sender, EventArgs e)
        {
            FormAdicionarMedico formAdicionarMedico = new FormAdicionarMedico(this);
            formAdicionarMedico.Show();
            Hide();
        }

        /// <summary>
        /// Botão de Voltar ao menu principal. Volta para o menu principal (inicial).
        /// </summary>
        private void BotaoVoltarPrincipal(object sender, EventArgs e)
        {
            formMenu.Show();
            Hide();
        }

        /// <summary>
        /// Método para buscar o nome de uma especialidade, através do seu id. Executa uma query SQL para ir buscar à base de dados, a especialidade com o mesmo id.
        /// Utilizada para ir buscar o nome da especialidade do médico, para apresentar na List View (Evento Load do form).
        /// </summary>
        /// <param name="id">ID da especialidade</param>
        /// <returns>Nome da especialidade</returns>
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

        /// <summary>
        /// Faz refresh á tabela dos médicos. Executa uma query SQL para ir buscar à base de dados, todos os médicos registados, e coloca-los na List View
        /// </summary>
        public void RefreshTabelaMedicos()
        {
            lvListaMedicos.Items.Clear();

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
    }
}
