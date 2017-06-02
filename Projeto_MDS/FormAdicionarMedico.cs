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

        /// <summary>
        /// Especialidade Selecionada, no form de Selecionar Especialidade.
        /// </summary>
        private Especialidades especialidadeSelecionada;

        public FormAdicionarMedico(FormGestaoMedicos form)
        {
            InitializeComponent();

            formGestaoMedicos = form;
        }

        /// <summary>
        /// Botão de Selecionar Especialidade. Mostra o form para selecionar um especialidade existente.
        /// </summary>
        private void BotaoSelecionarEspecialidade(object sender, EventArgs e)
        {
            FormSelecionarEspecialidade formSelecionarEspecialidade = new FormSelecionarEspecialidade(this);
            formSelecionarEspecialidade.Show();
            Hide();
        }

        /// <summary>
        /// Botão de Adicionar Médico. Verifica se os campos estão vazios, e 
        /// </summary>
        private void BotaoAdicionarMedico(object sender, EventArgs e)
        {
            if(tbNome.Text.Length > 0 && tbNSS.Text.Length > 0)
            {
                if(tbEspecialidade.Text.Length > 0)
                {
                    int nissMedico;
                    string nissForm = tbNSS.Text.Trim();

                    //Converte o NISS inserido para um inteiro. Se não conter caratéres ou caratéres especiais, devolve um boolean de tipo true.
                    if (Int32.TryParse(nissForm, out nissMedico))
                    {
                        //Se a hora de entrada inserida é antes da hora de saida inserida, devolve true.
                        if (dtpHoraEntrada.Value.CompareTo(dtpHoraSaida.Value) < 0)
                        {
                            string usernameMedico = tbUsername.Text.Trim();
                            string passwordMedico = mtbPassword.Text;
                            string nomeMedico = tbNome.Text.Trim();
                            string horaEntradaMedico = dtpHoraEntrada.Text;
                            string horaSaidaMedico = dtpHoraSaida.Text;
                            Especialidades especialidadeMedico = especialidadeSelecionada;

                            //Mensagem de Confirmação
                            DialogResult confirmacaoAdicionar = MessageBox.Show("Tem a certeza qe deseja inserir o médico '" + nomeMedico + "' ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (confirmacaoAdicionar == DialogResult.Yes)
                            {
                                //Se a especialidade selecionada é do tipo Especialidades. (Redundante, usado apenas para validar o valor de retorno do form de Selecionar Especialidade)
                                if (especialidadeMedico is Especialidades)
                                {
                                    Medicos medico = new Medicos(usernameMedico, passwordMedico, nomeMedico, horaEntradaMedico, horaSaidaMedico, nissMedico, especialidadeMedico);

                                    try
                                    {
                                        if (medico.VerificarDadosMedico())
                                        {
                                            if (medico.Adicionar())
                                            {
                                                MessageBox.Show("Médico inserido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                formGestaoMedicos.RefreshTabelaMedicos();
                                                formGestaoMedicos.Show();
                                                Close();
                                            }
                                        }

                                        else
                                        {
                                            MessageBox.Show("O médico inserido já existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }

                                    catch (Exception)
                                    {
                                        MessageBox.Show("Ocorreu um erro na inserção do médico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
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

        /// <summary>
        /// Botão de Cancelar. Voltar para o menu de gestão de médicos.
        /// </summary>
        private void BotaoCancelarMedico(object sender, EventArgs e)
        {
            formGestaoMedicos.Show();
            Hide();
        }

        /// <summary>
        /// Método para receber a especialidade selecionada, no form de Selecionar Especialidade.
        /// </summary>
        /// <param name="especialidade">Especialidade Selecionada</param>
        public void GetFormSelecionarEspecialidade(Especialidades especialidade)
        {
            tbEspecialidade.Text = especialidade.Nome;

            especialidadeSelecionada = especialidade;
        }
    }
}
