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
    public partial class FormSelecionarEspecialidade : Form
    {
        private FormAdicionarMedico formAdicionarMedico;

        public FormSelecionarEspecialidade(FormAdicionarMedico form)
        {
            InitializeComponent();

            formAdicionarMedico = form;
        }

        private void FormSelecionarEspecialidade_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    string queryString = "SELECT * from especialidade";

                    using (SqlCommand querySql = new SqlCommand(queryString, connection))
                    {
                        connection.Open();

                        using (SqlDataReader queryReader = querySql.ExecuteReader())
                        {
                            if (queryReader.HasRows)
                            {
                                while (queryReader.Read())
                                {
                                    ListViewItem listViewRow = new ListViewItem(queryReader["Id"].ToString());
                                    listViewRow.SubItems.Add(queryReader["nome"].ToString());
                                    lvListaEspecialidades.Items.Add(listViewRow);
                                }
                            }
                        }

                        connection.Close();
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no carregamento das especialidades.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotaoSelecionarEspecialidade(object sender, EventArgs e)
        {
            if(lvListaEspecialidades.SelectedItems.Count > 0)
            {
                string especialidadeSelecionada = lvListaEspecialidades.SelectedItems[0].SubItems[1].Text.ToString();

                Especialidades especialidade = new Especialidades(especialidadeSelecionada);

                formAdicionarMedico.GetFormSelecionarEspecialidade(especialidade);
                formAdicionarMedico.Show();
                Close();
            }
        }

        private void BotaoCancelarEspecialidade(object sender, EventArgs e)
        {
            formAdicionarMedico.Show();
            Hide();
        }
    }
}
