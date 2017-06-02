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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Desktop\Rep_ProjetoMDS\Projeto_MDS_1617\Projeto_MDS\basedadoshospital.mdf;Integrated Security=True");
        Boolean nova;
        int idmarcacao;
        Utilizadores utilizador;
        int idutilizador;
        public FormConsultaMedica(int idmarcacao1, Utilizadores utilizador1, int idutilizador1)
        {
            InitializeComponent();
            idmarcacao = idmarcacao1;
            utilizador = utilizador1;
            idutilizador = idutilizador1;
            carregarDadosMarcacao(idmarcacao);
            carregarTiposSintomas();
            cmbtiposintoma.SelectedIndex = 0;
            nova = true;

            Boolean jaregistada = verificaExisteConsulta(idmarcacao);
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

            string tiposintoma = getNomeTipoSintoma(id_tiposintomas);
            MessageBox.Show(id_tiposintomas + " - " + tiposintoma);
            cmbtiposintoma.SelectedItem = tiposintoma;
            tbxdescricaosintomas.Text = descricao_sintomas;
            tbxmedicamentos.Text = medicacao_tratamentos;
        }

        private string getNomeTipoSintoma(int id_tiposintoma)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader reader;
            string nome = "";
            cmd.CommandText = "SELECT * FROM tipo_sintoma WHERE Id = " + id_tiposintoma;

            cmd.CommandType = CommandType.Text;

            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    nome = reader[1].ToString();
                }
            }
            con.Close();
            return nome;
        }

        
        private Boolean verificaExisteConsulta(int idmarcacao)
        {
            Boolean existe = false;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT * FROM consulta WHERE id_marcacao = " + idmarcacao;

            cmd.CommandType = CommandType.Text;

            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader[0]);
                    int id_tiposintoma = Convert.ToInt32(reader[1]);
                    int id_marcacao = Convert.ToInt32(reader[2]);
                    string descricao_sintomas = reader[3].ToString();
                    string medicacao_tratamentos = reader[4].ToString();
                    existe = true;
                }
            }

            con.Close();
            return existe;
        }

        private void carregarTiposSintomas()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT * FROM tipo_sintoma";

            cmd.CommandType = CommandType.Text;

            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    int id = Convert.ToInt32(reader[0]);
                    string nome = reader[1].ToString();
                    string observacoes = reader[2].ToString();

                    TipoSintoma tiposintoma = new TipoSintoma(nome, observacoes);

                    cmbtiposintoma.Items.Add(tiposintoma.Nome);
                }
            }
            con.Close();
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
            

            if(cmbtiposintoma.SelectedIndex != -1 && tbxdescricaosintomas.Text.Length > 0 && tbxmedicamentos.Text.Length > 0)
            {
                string tiposintoma = cmbtiposintoma.SelectedItem.ToString();
                string descricaosintomas = tbxdescricaosintomas.Text;
                string medicamentos = tbxmedicamentos.Text;

                int idtiposintoma = getIdTipoSintoma(tiposintoma);

                Consulta consulta = new Consulta(idtiposintoma, idmarcacao, descricaosintomas, medicamentos);
                if(nova == true)
                {
                    guardarConsulta(consulta);
                }
                else
                {
                    alterarConsulta(consulta);
                }
            }
            else
            {
                MessageBox.Show("Preencha os dados corretamente.", "Preenchimento de dados");
            }
        }

        private void alterarConsulta(Consulta consulta)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE consulta SET "
                + "id_tiposintoma = " + consulta.IdTipoSintoma + ", "
                + "descricao_sintomas = '" + consulta.DescricaoSintomas + "', "
                + "medicacao_tratamentos = '" + consulta.MedicamentosTratamentos + "'"
                + " WHERE id_marcacao = " + idmarcacao;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Consulta alterada com sucesso", "Registo de consulta");

        }

        private void guardarConsulta(Consulta consulta)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO consulta(id_tiposintoma, id_marcacao, descricao_sintomas, medicacao_tratamentos) VALUES (" + consulta.IdTipoSintoma + ", " + consulta.IdMarcacao + ",'" + consulta.DescricaoSintomas + "', '" + consulta.MedicamentosTratamentos  + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Consulta registada com sucesso", "Registo de consulta");
        }

        private int getIdTipoSintoma(string tiposintoma)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader reader;
            
            int id = 0;
            cmd.CommandText = "SELECT * FROM tipo_sintoma WHERE nome = '" + tiposintoma + "'";
            cmd.CommandType = CommandType.Text;

            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    id = Convert.ToInt32(reader[0]);
                }
            }
            con.Close();
            return id;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormConsultaMedica_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMinhasConsultas form = new FormMinhasConsultas(utilizador, idutilizador);
            form.Show();

        }
    }
}
