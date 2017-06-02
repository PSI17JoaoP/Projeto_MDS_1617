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
    public partial class FormConsultaMedica : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.connectionString);
        Boolean nova;
        int idmarcacao;
        Utilizadores utilizador;
        int idutilizador;
        Consulta consulta1;
        public FormConsultaMedica(int idmarcacao1, Utilizadores utilizador1, int idutilizador1)
        {
            InitializeComponent();
            idmarcacao = idmarcacao1;
            utilizador = utilizador1;
            idutilizador = idutilizador1;
            consulta1 = new Consulta();
            carregarDadosMarcacao(idmarcacao);


            List<TipoSintoma> tipossintomas = new List<TipoSintoma>();
            tipossintomas = consulta1.carregarTiposSintomas();
            cmbtiposintoma.Items.AddRange(tipossintomas.ToArray());

            cmbtiposintoma.SelectedIndex = 1;
            nova = true;

            Boolean jaregistada = consulta1.verificaExisteConsulta(idmarcacao);
            if(jaregistada == true)
            {
                nova = false;
                carregarConsulta(idmarcacao);
            }
            else
            {
                nova = true;
            }
        }

        private void carregarConsulta(int idmarcacao)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader reader;

            int id = 0;
            int id_tiposintomas = 0;
            int id_marcacao = 0;
            string descricao_sintomas = "";
            string medicacao_tratamentos = "";

            cmd.CommandText = "SELECT * FROM consulta WHERE id_marcacao = " + idmarcacao;

            cmd.CommandType = CommandType.Text;

            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader[0]);
                    id_tiposintomas = Convert.ToInt32(reader[1]);
                    id_marcacao = Convert.ToInt32(reader[2]);
                    descricao_sintomas = reader[3].ToString();
                    medicacao_tratamentos = reader[4].ToString();    
                }
            }
            con.Close();

            string tiposintoma = consulta1.getNomeTipoSintoma(id_tiposintomas);
            cmbtiposintoma.SelectedItem = tiposintoma;
            tbxdescricaosintomas.Text = descricao_sintomas;
            tbxmedicamentos.Text = medicacao_tratamentos;
        }

        private void carregarDadosMarcacao(int idmarcacao)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT m.id, m.data, m.hora, p.nome FROM marcacao m JOIN paciente p ON m.id_paciente = p.Id"
                + " WHERE m.Id = " + idmarcacao;

            cmd.CommandType = CommandType.Text;

            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                if (reader.Read()) { 
                    int id = Convert.ToInt32(reader[0]);
                    DateTime data = Convert.ToDateTime(reader[1]);
                    string hora = reader[2].ToString();
                    string nomepaciente = reader[3].ToString();

                    tbxdata.Text = data.ToString("dd/MM/yyyy");
                    string data1 = tbxdata.Text;
                    tbxhora.Text = hora;
                    tbxnomepaciente.Text = nomepaciente;
                }

            }

            con.Close();
        }

        private void btnregistar_Click(object sender, EventArgs e)
        {
            Consulta consulta2 = new Consulta();

            if(cmbtiposintoma.SelectedIndex != -1 && tbxdescricaosintomas.Text.Length > 0 && tbxmedicamentos.Text.Length > 0)
            {
                string tiposintoma = cmbtiposintoma.SelectedItem.ToString();
                string descricaosintomas = tbxdescricaosintomas.Text;
                string medicamentos = tbxmedicamentos.Text;

                int idtiposintoma = consulta2.getIdTipoSintoma(tiposintoma);

                Consulta consulta = new Consulta(idtiposintoma, idmarcacao, descricaosintomas, medicamentos);



                if(nova == true)
                {
                    Boolean guardado = consulta.guardarConsulta();
                    if(guardado == true)
                    {
                        MessageBox.Show("Consulta registada com sucesso", "Registo de Consulta");
                    }
                    else
                    {
                        MessageBox.Show("A consulta não foi registada", "Registo de Consulta");
                    }
                }
                else
                {
                    Boolean alterado = consulta.alterarConsulta(idmarcacao);

                    if(alterado == true)
                    {
                        MessageBox.Show("Consulta alterada com sucesso.", "Alteração de dados");
                    }
                    else
                    {
                        MessageBox.Show("A consulta não foi alterado.", "Alteração de dados");
                    }

                }
            }
            else
            {
                MessageBox.Show("Preencha os dados corretamente.", "Preenchimento de dados");
            }
        }

        private void FormConsultaMedica_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMinhasConsultas form = new FormMinhasConsultas(utilizador, idutilizador);
            form.Show();

        }
    }
}
