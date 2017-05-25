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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();

            connect = new SqlConnection();
            connect.ConnectionString = Properties.Settings.Default.connectionString;

            registosMarcacoes = new List<Marcacao>();
            registosMedicos = new List<Medicos>();
            registosEspecialidades = new List<Especialidades>();
        }

        //Conexão à BD
        SqlConnection connect;

        //#######################
        //Listas para guardar os dados en runtime - facilitar a gestão

        List<Marcacao> registosMarcacoes;
        List<Medicos> registosMedicos;
        List<Especialidades> registosEspecialidades;
        //#######################


        private void FormMenu_Load(object sender, EventArgs e)
        {
            connect.Open();

            DataSet dados = new DataSet();
            SqlCommand query = new SqlCommand();
            SqlDataReader results;
            string queryString;

            //Carregar Especialidades
            queryString = "SELECT nome FROM especialidade";
            query.CommandText = queryString;
            query.Connection = connect;

            results = query.ExecuteReader();

            if (results.HasRows)
            {
                while (results.Read())
                {
                    Especialidades especialidade = new Especialidades(results["nome"].ToString());
                    registosEspecialidades.Add(especialidade);
                }
            }
            //----------------------------------------

            //Carregar Médicos
            queryString = "SELECT username, password, medico.nome, hora_entrada, hora_saida, niss, especialidade.nome"
                        + "FROM utilizador"
                        + "JOIN medico ON utilizador.Id = medico.id_utilizador"
                        + "JOIN especialidade ON especialidade.Id = medico.id_especialidade";
            query.CommandText = queryString;
            query.Connection = connect;

            results = query.ExecuteReader();

            if (results.HasRows)
            {
                while (results.Read())
                {
                    Medicos medico = new Medicos(
                        results[0].ToString(),
                        results[1].ToString(),
                        results[2].ToString(),
                        results[3].ToString(),
                        results[4].ToString(),
                        (int)results[5],
                        results[6].ToString()
                    );
                    registosMedicos.Add(medico);
                }
            }
            //----------------------------------------

            //Carregar marcações

            queryString = "SELECT paciente.nome, data, hora, medico.nome"
                        + "FROM marcacao"
                        + "JOIN medico ON marcacao.id_medico = medico.id_utilizador"
                        + "JOIN paciente ON marcacao.id_paciente = paciente.id";
            query.CommandText = queryString;
            query.Connection = connect;

            results = query.ExecuteReader();

            if (results.HasRows)
            {
                while (results.Read())
                {
                    Marcacao marcacao = new Marcacao(
                        results[0].ToString(),
                        results[1].ToString(), 
                        results[2].ToString(), 
                        results[3].ToString()
                    );

                    registosMarcacoes.Add(marcacao);
                }
            }

            //----------------------------------------

            connect.Close();
        }

        private void btnMarcarConsulta_Click(object sender, EventArgs e)
        {
            FormMarcar form = new FormMarcar(this);
            form.Show();
            Hide();
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public bool AdicionarConsulta(Marcacao consulta)
        {
            bool result;

            try
            {
                registosMarcacoes.Add(consulta);
                result = true;
            }
            catch (Exception)
            {
                result = false;
                throw;
            }
            
            return result;
        }

        
    }
}
