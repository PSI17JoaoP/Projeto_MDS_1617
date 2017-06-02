using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MDS
{
    public class TipoSintoma
    {
        public string Nome { get; set; }
        public string Observacoes { get; set; }

        public TipoSintoma(string nome, string observacoes)
        {
            Nome = nome;
            Observacoes = observacoes;
        }

        public override string ToString()
        {
            //return Nome + " - " + Descricao;
            return Nome;
        }

        public Boolean guardarTipoSintoma()
        {
            Boolean guardado = false;
            using(SqlConnection con = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO tipo_sintoma(nome, obs) VALUES ('" + Nome + "', '" + Observacoes + "')";
                int resultado = cmd.ExecuteNonQuery();
                if(resultado > 0)
                {
                    guardado = true;
                }
                con.Close();
            }
            return guardado;
        }

        public Boolean alterarTipoSintoma(int idtiposintoma)
        {
            Boolean alterado = false;
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE tipo_sintoma SET "
                            + "nome = '" + Nome + "',"
                            + "obs = '" + Observacoes + "'"
                            + " WHERE Id = " + idtiposintoma;
                int resultado = cmd.ExecuteNonQuery();

                if (resultado > 0)
                {
                    alterado = true;
                }
                con.Close();
            }
            return alterado;
        }

        public Boolean verificarExisteTipoSintoma(int idtiposintoma)
        {
            Boolean existe = false;
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.connectionString)) {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                SqlDataReader reader;

                cmd.CommandText = "SELECT * FROM tipo_sintoma WHERE UPPER(nome) = '" + Nome + "' AND Id != " + idtiposintoma;
                cmd.CommandType = CommandType.Text;
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        existe = true;
                    }
                }
                con.Close();
            }
            return existe;
        }

        public Boolean verificarExisteTipoSintoma()
        {
            Boolean existe = false;
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                SqlDataReader reader;

                cmd.CommandText = "SELECT * FROM tipo_sintoma WHERE UPPER(nome) = '" + Nome + "'";
                cmd.CommandType = CommandType.Text;
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        existe = true;
                    }
                }

                con.Close();
            }
            return existe;
        }

        public Boolean apagarTipoSintoma(int idtiposintoma)
        {
            Boolean eliminado = false;
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                
                    cmd.CommandText = "DELETE FROM tipo_sintoma WHERE Id = " + idtiposintoma;
                    int resultado = cmd.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        eliminado = true;
                    }
                
                con.Close();
            }
            return eliminado;
        }

        private List<TipoSintoma> pesquisarNomeTipoSintoma(string nome)
        {
            List<TipoSintoma> tipossintomas = new List<TipoSintoma>();

            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.connectionString)) {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                SqlDataReader reader;

                cmd.CommandText = "SELECT * FROM tipo_sintoma WHERE nome LIKE '%" + nome + "%'";
                cmd.CommandType = CommandType.Text;
                reader = cmd.ExecuteReader();

                while (reader.HasRows)
                {
                    int id = Convert.ToInt32(reader[0]);
                    string nome1 = reader[1].ToString();
                    string obs = reader[2].ToString();

                    TipoSintoma tiposintoma = new TipoSintoma(nome1, obs);

                    tipossintomas.Add(tiposintoma);
                }
            }
            return tipossintomas;
        }
    }
}
