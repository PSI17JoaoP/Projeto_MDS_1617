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
    public partial class FormAdicionarMedico : Form
    {
        private FormGestaoMedicos formGestaoMedicos;

        public FormAdicionarMedico(FormGestaoMedicos form)
        {
            InitializeComponent();

            formGestaoMedicos = form;
        }

        private void BotaoSelecionarEspecialidade(object sender, EventArgs e)
        {
            FormSelecionarEspecialidade formSelecionarEspecialidade = new FormSelecionarEspecialidade(this);
            formSelecionarEspecialidade.Show();
            Hide();
        }

        private void BotaoAdicionarMedico(object sender, EventArgs e)
        {
            if(tbNome.Text.Length > 0 && tbNSS.Text.Length > 0)
            {
                if(tbEspecialidade.Text.Length > 0)
                {
                    int nissMedico;
                    string nissForm = tbNSS.Text.Trim();

                    if (Int32.TryParse(nissForm, out nissMedico))
                    {
                        if (dtpHoraEntrada.Value.CompareTo(dtpHoraSaida.Value) < 0)
                        {
                            string usernameMedico = tbUsername.Text.Trim();
                            string passwordMedico = HashPassword(mtbPassword.Text);
                            string nomeMedico = tbNome.Text.Trim();
                            string horaEntradaMedico = dtpHoraEntrada.Text;
                            string horaSaidaMedico = dtpHoraSaida.Text;
                            Especialidades especialidadeMedico = GetEspecialidadeForm(tbEspecialidade.Text);

                            if (especialidadeMedico is Especialidades)
                            {
                                Medicos medico = new Medicos(usernameMedico, passwordMedico, nomeMedico, horaEntradaMedico, horaSaidaMedico, nissMedico, especialidadeMedico);

                                formGestaoMedicos.CarregarMedico(medico);
                                formGestaoMedicos.Show();
                                Close();
                            }
                        }

                        else
                        {
                            MessageBox.Show("O horário escolhido é inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Não preencheu a especialidade do médico a inserir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Preencha todos os dados para a inserção do médico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotaoCancelarMedico(object sender, EventArgs e)
        {
            formGestaoMedicos.Show();
            Hide();
        }

        public void GetFormSelecionarEspecialidade(Especialidades especialidade)
        {
            tbEspecialidade.Text = especialidade.Nome;
        }

        private Especialidades GetEspecialidadeForm(string nomeEspecialidade)
        {
            Especialidades especialidadeMedico = null;

            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = Properties.Settings.Default.connectionString;

                connection.Open();

                SqlCommand querySql = new SqlCommand();
                SqlDataReader queryReader;

                string queryString = "SELECT nome FROM especialidade WHERE nome = @nomeEspecialidade";
                querySql.CommandText = queryString;

                SqlParameter nomeSQL = new SqlParameter("@nomeEspecialidade", nomeEspecialidade);
                querySql.Parameters.Add(nomeSQL);
                querySql.Connection = connection;

                using (queryReader = querySql.ExecuteReader())
                {
                    if (queryReader.HasRows)
                    {
                        queryReader.Read();
                        especialidadeMedico = new Especialidades(queryReader["nome"].ToString());
                    }

                    else
                    {
                        MessageBox.Show("Não existe nenhuma especialidade com o nome inserido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch(Exception)
            {
                //return null;
            }

            return especialidadeMedico;
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
