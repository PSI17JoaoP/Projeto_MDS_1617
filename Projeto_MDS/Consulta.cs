using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MDS
{
    public class Consulta
    {
        public int IdTipoSintoma { get; set; }
        public int IdMarcacao { get; set; }
        public string DescricaoSintomas { get; set; }
        public string MedicamentosTratamentos { get; set; }

        public Consulta()
        {

        }

        public Consulta(int idtiposintoma, int idmarcacao, string descricaosintomas, string medicamentostratamentos)
        {
            IdTipoSintoma = idtiposintoma;
            IdMarcacao = idmarcacao;
            DescricaoSintomas = descricaosintomas;
            MedicamentosTratamentos = medicamentostratamentos;
        }

        public override string ToString()
        {
            return IdTipoSintoma + " - " + IdMarcacao + " - " + DescricaoSintomas + " - " + MedicamentosTratamentos;
        }



        public Boolean guardarConsulta()
        {
            Boolean guardado = false;

            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.connectionString)) {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO consulta(id_tiposintoma, id_marcacao, descricao_sintomas, medicacao_tratamentos) VALUES (" + IdTipoSintoma + ", " + IdMarcacao + ",'" + DescricaoSintomas + "', '" + MedicamentosTratamentos + "')";
                int resultado = cmd.ExecuteNonQuery();

                if(resultado > 0)
                {
                    guardado = true;
                }
                con.Close();

                return guardado;
            }
        }

        public Boolean alterarConsulta(int idmarcacao)
        {
            Boolean alterado = false;
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE consulta SET "
                    + "id_tiposintoma = " + IdTipoSintoma + ", "
                    + "descricao_sintomas = '" + DescricaoSintomas + "', "
                    + "medicacao_tratamentos = '" + MedicamentosTratamentos + "'"
                    + " WHERE id_marcacao = " + idmarcacao;
                int resultado = cmd.ExecuteNonQuery();
                
                if(resultado > 0)
                {
                    alterado = true;
                }
               
                con.Close();

                return alterado;
            }

        }

        public int getIdTipoSintoma(string tiposintoma)
        {
            int id = -1;
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                SqlDataReader reader;
                
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
            }
            return id;
        }

        public List<TipoSintoma> carregarTiposSintomas()
        {
            List<TipoSintoma> lista = new List<TipoSintoma>();
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                SqlDataReader reader;

                cmd.CommandText = "SELECT * FROM tipo_sintoma";

                cmd.CommandType = CommandType.Text;

                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader[0]);
                        string nome = reader[1].ToString();
                        string observacoes = reader[2].ToString();

                        TipoSintoma tiposintoma = new TipoSintoma(nome, observacoes);

                        lista.Add(tiposintoma);
                    }
                }
                con.Close();
            }
            return lista;
        }

        public string getNomeTipoSintoma(int id_tiposintoma)
        {
            string nome = "";
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                SqlDataReader reader;
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
            }
            return nome;
        }

        public Boolean verificaExisteConsulta(int idmarcacao)
        {
            Boolean existe = false;
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.connectionString))
            {
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
                }
            return existe;
        }
    }
}
