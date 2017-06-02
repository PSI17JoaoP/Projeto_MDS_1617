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
    public partial class FormMinhasConsultas : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.connectionString);
        Utilizadores utilizador;
        int idutilizador;
        Marcacao marcacao;
        public FormMinhasConsultas(Utilizadores utilizador1, int idutilizador1)
        {
            InitializeComponent();
            utilizador = utilizador1;
            idutilizador = idutilizador1;
            cbpesquisarpor.SelectedIndex = 0;
            toolStripTextBox2.Text = utilizador1.Username;
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idmarcacao = (int)dgvminhasconsultas.CurrentRow.Cells[0].Value;

            FormConsultaMedica form = new FormConsultaMedica(idmarcacao, utilizador, idutilizador);
            form.Show();
            Hide();

            
            //enviar o idmarcacao e o idutilizador;
        }

        private void asMinhasConsultasMédicasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormMinhasConsultas_Load(object sender, EventArgs e)
        {
            atualizarTabela();
        }

        private void atualizarTabela()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT m.id, m.data, m.hora, p.nome FROM marcacao m JOIN paciente p ON m.id_paciente = p.Id"
            + " WHERE m.id_medico = " + idutilizador;
            //cmd.CommandText = "SELECT m.id, m.data, m.hora FROM marcacao m WHERE m.id_medico = " + idutilizador;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvminhasconsultas.DataSource = dt;

            con.Close();
        }

        private void cbpesquisarpor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbpesquisarpor.SelectedIndex;
            if (i != -1)
            {
                string pesquisa = cbpesquisarpor.SelectedItem.ToString();

                if(pesquisa.Equals("Nome Paciente"))
                {
                    label2.Text = "Nome de Paciente:";
                }
                if (pesquisa.Equals("Data"))
                {
                    label2.Text = "Data:";
                }
                if (pesquisa.Equals("Hora"))
                {
                    label2.Text = "Hora:";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int i = cbpesquisarpor.SelectedIndex;
            if (i != -1)
            {
                string pesquisapor = cbpesquisarpor.SelectedItem.ToString();
                string pesquisa = tbxpesquisa.Text;
                if(pesquisa.Length > 0) { 
                    if(pesquisapor.Equals("Nome Paciente"))
                    {
                        pesquisarConsultaNomePaciente(pesquisa);
                    }
                    if (pesquisapor.Equals("Data"))
                    {
                        pesquisarConsultaData(pesquisa);
                    }
                    if (pesquisapor.Equals("Hora"))
                    {
                        pesquisarConsultaHora(pesquisa);
                    }
                }
                else
                {
                    atualizarTabela();
                }
            }
        }

        private void pesquisarConsultaHora(string pesquisa)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT m.id, m.data, m.hora, p.nome FROM marcacao m JOIN paciente p ON m.id_paciente = p.Id"
            + " WHERE m.id_medico = " + idutilizador + " AND m.hora LIKE '%" + pesquisa + "%'";
            //cmd.CommandText = "SELECT m.id, m.data, m.hora FROM marcacao m WHERE m.id_medico = " + idutilizador;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvminhasconsultas.DataSource = dt;
            if(dgvminhasconsultas.RowCount == 0)
            {
                MessageBox.Show("Não existem dados com esse filtro.");
            }
            con.Close();
        }

        private void pesquisarConsultaData(string pesquisa)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT m.id, m.data, m.hora, p.nome FROM marcacao m JOIN paciente p ON m.id_paciente = p.Id"
            + " WHERE m.id_medico = " + idutilizador + " AND m.data LIKE '%" + pesquisa + "%'";
            //cmd.CommandText = "SELECT m.id, m.data, m.hora FROM marcacao m WHERE m.id_medico = " + idutilizador;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvminhasconsultas.DataSource = dt;
            if(dgvminhasconsultas.RowCount == 0)
            {
                MessageBox.Show("Não existem dados com esse filtro.");
            }
            con.Close();
        }

        private void pesquisarConsultaNomePaciente(string pesquisa)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT m.id, m.data, m.hora, p.nome FROM marcacao m JOIN paciente p ON m.id_paciente = p.Id"
            + " WHERE m.id_medico = " + idutilizador + " AND p.nome LIKE '%" + pesquisa + "%'";
            //cmd.CommandText = "SELECT m.id, m.data, m.hora FROM marcacao m WHERE m.id_medico = " + idutilizador;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvminhasconsultas.DataSource = dt;
            if(dgvminhasconsultas.RowCount == 0)
            {
                MessageBox.Show("Não existem dados com esse filtro.");
            }
            con.Close();
        }

        private void FormMinhasConsultas_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPrincipalMedico form = new FormPrincipalMedico(utilizador, idutilizador);
            form.Show();

        }
    }
}
