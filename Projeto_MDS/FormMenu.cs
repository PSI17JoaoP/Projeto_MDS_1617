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
            registosPacientes = new List<Pacientes>();
        }

        //Conexão à BD
        SqlConnection connect;

        //#######################
        //Listas para guardar os dados en runtime - facilitar a gestão

        List<Marcacao> registosMarcacoes;
        List<Medicos> registosMedicos;
        List<Especialidades> registosEspecialidades;
        List<Pacientes> registosPacientes;
        //#######################

        public List<Pacientes> Pacientes()
        {
            return registosPacientes;
        }

        public List<Medicos> Medicos()
        {
            return registosMedicos;
        }

        public List<Especialidades> Especialidades()
        {
            return registosEspecialidades;
        }

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

            results.Close();
            //----------------------------------------

            //Carregar Médicos
            queryString = "SELECT username, password, medico.nome, medico.hora_entrada, medico.hora_saida, medico.niss, especialidade.nome"
                        + " FROM utilizador"
                        + " JOIN medico ON utilizador.Id = medico.id_utilizador"
                        + " JOIN especialidade ON especialidade.Id = medico.id_especialidade";
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
                        Convert.ToInt32(results[5]),
                        new Especialidades(results[6].ToString())
                    );
                    registosMedicos.Add(medico);
                }
            }

            results.Close();
            //----------------------------------------

            //Carregar marcações

            queryString = "SELECT paciente.nome, data, hora, medico.nome"
                        + " FROM marcacao"
                        + " JOIN medico ON marcacao.id_medico = medico.id_utilizador"
                        + " JOIN paciente ON marcacao.id_paciente = paciente.id";
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

            results.Close();
            //----------------------------------------

            //Carregar marcações

            queryString = "SELECT nome, telefone, niss"
                        + " FROM paciente";
            query.CommandText = queryString;
            query.Connection = connect;

            results = query.ExecuteReader();

            if (results.HasRows)
            {
                while (results.Read())
                {
                    Pacientes paciente = new Pacientes(
                        results[0].ToString(), 
                        Convert.ToInt32(results[1]),
                        Convert.ToInt32(results[2])
                    );

                    registosPacientes.Add(paciente);
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

        private void btnAdicionarMedico_Click(object sender, EventArgs e)
        {
            FormGestaoMedicos formGestaoMedicos = new FormGestaoMedicos(this);
            formGestaoMedicos.Show();
            Hide();
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public bool AdicionarConsulta(Marcacao marcacao)
        {
            bool result;

            try
            {
                registosMarcacoes.Add(marcacao);
                result = true;
            }
            catch (Exception)
            {
                result = false;
                throw;
            }
            
            
            return result;
        }

        public bool VerDisponibilidadeMedico(string medico, string data, string hora)
        {
            bool result = false;

            foreach (Marcacao marcacao in registosMarcacoes)
            {
                result = marcacao.VerificarDisponibilidadeMedica(medico, data, hora);
            }

            return result;
        }

    }
}
