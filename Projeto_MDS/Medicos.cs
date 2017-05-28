using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MDS
{
    public class Medicos : Utilizadores
    {
        public string Nome { get; set; }
        public string HoraEntrada { get; set; }
        public string HoraSaida { get; set; }
        public Especialidades Especialidade { get; set; }

        private int _niss;

        public Medicos(string username, string pass, string nome, string horaentrada, string horasaida, int niss, Especialidades especialidade) : base(username, pass)
        {
            Nome = nome;
            HoraEntrada = horaentrada;
            HoraSaida = horasaida;
            Niss = niss;
            Especialidade = especialidade;
        }

        public int Niss
        {
            get{ return _niss; }

            set
            {
                if (value.ToString().Length == 9)
                {
                    _niss = value;
                }

                else
                {
                    throw new Exception("NISS inválido");
                }
            }
        }

        public bool Adicionar()
        {
            bool medicoInserido = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    string queryUserString = "INSERT INTO utilizador(username, password) VALUES (@username, @password);" + "SELECT @idUser = SCOPE_IDENTITY()";

                    using (SqlCommand queryUserSql = new SqlCommand(queryUserString, connection))
                    {
                        connection.Open();

                        queryUserSql.Parameters.AddWithValue("@username", Username);
                        queryUserSql.Parameters.AddWithValue("@password", Password);
                        queryUserSql.Parameters.Add("@idUser", SqlDbType.Int).Direction = ParameterDirection.Output;

                        queryUserSql.ExecuteNonQuery();

                        int idUser = (int) queryUserSql.Parameters["@idUser"].Value;

                        string queryMedicoString = "INSERT INTO medico (id_utilizador, nome, niss, hora_entrada, hora_saida, id_especialidade) VALUES (@id, @nome, @niss, @hora_entrada, @hora_saida, @id_especialidade)";

                        using (SqlCommand queryMedicoSql = new SqlCommand(queryMedicoString, connection))
                        {
                            queryMedicoSql.Parameters.AddWithValue("@id", idUser);
                            queryMedicoSql.Parameters.AddWithValue("@nome", Nome);
                            queryMedicoSql.Parameters.AddWithValue("@niss", Niss);
                            queryMedicoSql.Parameters.AddWithValue("@hora_entrada", HoraEntrada);
                            queryMedicoSql.Parameters.AddWithValue("@hora_saida", HoraSaida);
                            queryMedicoSql.Parameters.AddWithValue("@id_especialidade", GetEspecialidadeID());

                            int rowsInseridas = queryMedicoSql.ExecuteNonQuery();

                            if(rowsInseridas > 0)
                            {
                                medicoInserido = true;
                            }
                        }

                        connection.Close();
                    }
                }
            }

            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no pedido à base de dados");
            }

            return medicoInserido;
        }

        public int GetEspecialidadeID()
        {
            int idEspecialidade = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    string queryString = "SELECT * FROM especialidade";

                    using (SqlCommand querySql = new SqlCommand(queryString, connection))
                    {
                        connection.Open();

                        using (SqlDataReader queryReader = querySql.ExecuteReader())
                        {
                            if (queryReader.HasRows)
                            {
                                while (queryReader.Read())
                                {
                                    if (queryReader["nome"].ToString() == Especialidade.Nome)
                                    {
                                        idEspecialidade = (int) queryReader["Id"];
                                        break;
                                    }
                                }
                            }
                        }

                        connection.Close();
                    }
                }
            }

            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no pedido à base de dados");
            }

            return idEspecialidade;
        }

        public bool VerificarDadosMedico()
        {
            bool naoExisteDados = true;

            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    string queryString = "SELECT * FROM medico";

                    using (SqlCommand querySql = new SqlCommand(queryString, connection))
                    {
                        connection.Open();

                        using (SqlDataReader queryReader = querySql.ExecuteReader())
                        {
                            if (queryReader.HasRows)
                            {
                                while (queryReader.Read())
                                {
                                    if (Username == queryReader["username"].ToString() || Niss.ToString() == queryReader["niss"].ToString())
                                    {
                                        naoExisteDados = false;
                                    }
                                }
                            }
                        }

                        connection.Close();
                    }
                }
            }

            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no pedido à base de dados");
            }

            return naoExisteDados;
        }
    }
}
