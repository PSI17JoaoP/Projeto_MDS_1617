using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
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

        /// <summary>
        /// Getter e Setter para o NISS. Apenas niss's contem 9 digitos serão aceites.
        /// </summary>
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

        /// <summary>
        /// Método de Adicionar um médico à base de dados. Executa uma query SQL, com os dados do objeto, para inserir a médico à base de dados.
        /// </summary>
        /// <returns>Boolean que determina se a inserção foi bem sucedida</returns>
        public bool Adicionar()
        {
            bool medicoInserido = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    //Inserção do username e password(hash) do médico na tabela 'utilizador';
                    //Adquirição do ID do user selecionado, através da função SQL SCOPE_IDENTITY (Retira o ultimo id do ultimo registo inserido, ou seja, o único registo, no mesmo scope)
                    //(https://docs.microsoft.com/en-us/sql/t-sql/functions/scope-identity-transact-sql)
                    string queryUserString = "INSERT INTO utilizador(username, password) VALUES (@username, @password);" + "SELECT @idUser = SCOPE_IDENTITY()";

                    using (SqlCommand queryUserSql = new SqlCommand(queryUserString, connection))
                    {
                        connection.Open();

                        //Uso de Parameters para evitar SQL Injection
                        queryUserSql.Parameters.AddWithValue("@username", Username);
                        queryUserSql.Parameters.AddWithValue("@password", Password);

                        //Definição do parâmetro do ID do user. Nessesário para ser possivel retirar o valor adquido na query.
                        queryUserSql.Parameters.Add("@idUser", SqlDbType.Int).Direction = ParameterDirection.Output;

                        queryUserSql.ExecuteNonQuery();

                        //Guarda o ID do utilizador (médico) inserido, para usar na inserção na tabela 'medico' (como Foreign Key).
                        int idUser = (int) queryUserSql.Parameters["@idUser"].Value;

                        //-------------------------------------

                        //Inserção dos dados do médico na tabela 'medico'
                        string queryMedicoString = "INSERT INTO medico (id_utilizador, nome, niss, hora_entrada, hora_saida, id_especialidade) VALUES (@id, @nome, @niss, @hora_entrada, @hora_saida, @id_especialidade)";

                        using (SqlCommand queryMedicoSql = new SqlCommand(queryMedicoString, connection))
                        {
                            queryMedicoSql.Parameters.AddWithValue("@id", idUser);
                            queryMedicoSql.Parameters.AddWithValue("@nome", Nome);
                            queryMedicoSql.Parameters.AddWithValue("@niss", Niss);
                            queryMedicoSql.Parameters.AddWithValue("@hora_entrada", HoraEntrada);
                            queryMedicoSql.Parameters.AddWithValue("@hora_saida", HoraSaida);
                            queryMedicoSql.Parameters.AddWithValue("@id_especialidade", ObterIdEspecialidade());

                            //Guarda o numero de registo afetados pela query, ou seja, o numero de registo inseridos.
                            int rowsInseridas = queryMedicoSql.ExecuteNonQuery();

                            //Se o registo foi inserido, iguala a boolean medicoInserido a true;
                            if (rowsInseridas > 0)
                            {
                                medicoInserido = true;
                            }
                        }

                        //--------------------------------------

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

        /// <summary>
        /// Método para verificar se os dados do médico, sendo estes o username e o NISS, já existem na base de dados.
        /// Executa uma query SQL que devolve os dados de todos os médicos das tabelas 'utilizador' e 'medico'.
        /// De seguida, verifica se os dados inseridos são iguais aos dados existentes nas tabelas.
        /// </summary>
        /// <returns>Boolean que verifica se existe, ou não, os dados inseridos. True -> não existem; False->Já existem</returns>
        public bool VerificarDadosMedico()
        {
            bool naoExisteDados = true;

            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    string queryString = "SELECT * FROM medico JOIN utilizador ON medico.id_utilizador = utilizador.Id";

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

        /// <summary>
        /// Método que obtem o id da Especialidade do médico. Executa uma query SQL para buscar à base de dados, todas as especialidades registadas.
        /// De seguida, compára o nome da especialidade com os nomes das especialidades existentes na BD.
        /// Se for igual, guarda o id da especialidade da BD e quebra o ciclo de leitura de resultados da query.
        /// </summary>
        /// <returns>ID da Especialidade</returns>
        private int ObterIdEspecialidade()
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
    }
}
