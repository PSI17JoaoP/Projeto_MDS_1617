using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto_MDS
{
    public partial class FormTipoSintoma : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.connectionString);
        private Boolean nova;
        Utilizadores utilizador;
        int idutilizador;
        public FormTipoSintoma(Utilizadores utilizador1, int idutilizador1)
        {
            InitializeComponent();
            nova = true;
            utilizador = utilizador1;
            idutilizador = idutilizador1;
            cbxpesquisarpor.SelectedIndex = 0;
        }

        private void btnregistar_Click(object sender, EventArgs e)
        {
            if(tbxnome.Text.Length > 0)
            {
                string nome = tbxnome.Text;
                string descricao = tbxdescricao.Text;
                if (descricao.Equals(""))
                {
                    descricao = "Por preencher";
                }
                TipoSintoma tiposintoma;
                if (nova == true)
                {
                    tiposintoma = new TipoSintoma(nome, descricao);
                    Boolean existe = tiposintoma.verificarExisteTipoSintoma();
                    if(existe == false) {
                        Boolean guardado = false;
                        
                        guardado = tiposintoma.guardarTipoSintoma();
                        if(guardado == true)
                        {
                            nova = true;
                            limparDados();
                        }
                        else
                        {
                            MessageBox.Show("O tipo de sintoma não foi criado.", "Criação de dados");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Já existe um tipo de sintoma com esse nome.", "Duplicação de dados");
                    }
                }
                else
                {
                    if (dgvtiposdesintomas.SelectedRows.Count > 0)
                    {
                        int idtiposintoma = (int)dgvtiposdesintomas.CurrentRow.Cells[0].Value;
                        tiposintoma = new TipoSintoma(nome, descricao);
                        Boolean existe = tiposintoma.verificarExisteTipoSintoma(idtiposintoma);
                        if (existe == false) {
                            Boolean alterado = false;

                            alterado = tiposintoma.alterarTipoSintoma(idtiposintoma);
                            if (alterado == true)
                            {
                                nova = true;
                                limparDados();
                            }
                            else
                            {
                                MessageBox.Show("O tipo de sintoma não foi alterado.", "Alteração de dados");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Já existe um tipo de sintoma com esse nome.", "Duplicação de dados");
                        }
                    }
                }
                //nova = true;
                //limparDados();
            }
            else
            {
                MessageBox.Show("Preencha o nome do tipo de sintoma", "Preenchimento de dados");
            }
            

            //MessageBox.Show("Record inserted sucessfully");

            atualizarTabela();

        }

        /*private Boolean verificarExisteTipoSintoma(string nome, int idtiposintoma)
        {
            Boolean existe = false;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT * FROM tipo_sintoma WHERE UPPER(nome) = '" + nome + "' AND Id != " + idtiposintoma;
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
            return existe;
        }*/

        /*private Boolean verificarExisteTipoSintoma(string nome)
        {
            Boolean existe = false;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT * FROM tipo_sintoma WHERE UPPER(nome) = '" + nome + "'";
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
            return existe;
        }*/

        /*private void alterarTipoSintoma(TipoSintoma tiposintoma)
        {
            int idtiposintoma = (int)dgvtiposdesintomas.CurrentRow.Cells[0].Value;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE tipo_sintoma SET "
                        + "nome = '" + tiposintoma.Nome + "',"
                        + "obs = '" + tiposintoma.Observacoes + "'"
                        + " WHERE Id = " + idtiposintoma;
            cmd.ExecuteNonQuery();
            con.Close();
            nova = true;
            limparDados();
        }
        */

        /*private void guardarTipoSintoma(TipoSintoma tiposintoma)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO tipo_sintoma(nome, obs) VALUES ('" + tiposintoma.Nome + "', '" + tiposintoma.Observacoes + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            nova = true;
            limparDados();
        }*/

        private void atualizarTabela()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM tipo_sintoma";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvtiposdesintomas.DataSource = dt;

            con.Close();

            

            int i = dgvtiposdesintomas.Rows.Count;
            dgvtiposdesintomas.CurrentCell = dgvtiposdesintomas.Rows[i -1].Cells[0];

        }

        private void FormTipoSintoma_Load(object sender, EventArgs e)
        {
            atualizarTabela();
        }

        private void dgvtiposdesintomas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nova = false;
            int i = (int)dgvtiposdesintomas.CurrentRow.Cells[0].Value;
            string nome = (string)dgvtiposdesintomas.CurrentRow.Cells[1].Value;
            tbxnome.Text = nome;
            string descricao = (string)dgvtiposdesintomas.CurrentRow.Cells[2].Value;
            tbxdescricao.Text = descricao;
            btnapagar.Enabled = true;
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            int idtiposintoma = (int)dgvtiposdesintomas.CurrentRow.Cells[0].Value;
            string nome = dgvtiposdesintomas.CurrentRow.Cells[1].Value.ToString();
            string obs = dgvtiposdesintomas.CurrentRow.Cells[2].Value.ToString();
            TipoSintoma tiposintoma = new TipoSintoma(nome, obs);

            DialogResult confirmar = MessageBox.Show("Deseja eliminar o tipo de sintoma selecionado?", "Eliminação de dados", MessageBoxButtons.YesNo);
            if (confirmar == DialogResult.Yes)
            {
                Boolean eliminado = tiposintoma.apagarTipoSintoma(idtiposintoma);

                if(eliminado == true)
                {
                    MessageBox.Show("O tipo de sintoma foi eliminado.", "Eliminação de dados");
                    atualizarTabela();
                    nova = true;
                    limparDados();
                }
                else
                {
                    MessageBox.Show("Erro na eliminação do tipo de sintoma. O tipo de sintoma está associado a uma consulta.", "Eliminação de dados");
                }
            }

            
        }

        /*private void apagarTipoSintoma(int idtiposintoma)
        {
            
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                try
                {
                    cmd.CommandText = "DELETE FROM tipo_sintoma WHERE Id = " + idtiposintoma;
                    int resultado = cmd.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                       
                    }
                }
                catch (Exception)
                {
                    
                }
                con.Close();

                
                
        }*/



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbxpesquisarpor.SelectedIndex;
            if(i != -1)
            {
                string pesquisa = cbxpesquisarpor.SelectedItem.ToString();
                if (pesquisa.Equals("Id"))
                {
                    label2.Text = "Id:";
                }
                if (pesquisa.Equals("Nome"))
                {
                    label2.Text = "Nome:";
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*int i = cbxpesquisarpor.SelectedIndex;
            if (i != -1)
            {
                string pesquisa = cbxpesquisarpor.SelectedItem.ToString();
                if (pesquisa.Equals("Id"))
                {
                    int id = Convert.ToInt32(tbxpesquisa.Text);
                    pesquisarIdTipoSintoma(id);
                }
                else
                {
                    string nome = tbxpesquisa.Text;
                    pesquisarNomeTipoSintoma(nome);
                }
            }*/
        }

        

        private void tbxpesquisa_TextChanged(object sender, EventArgs e)
        {
            int i = cbxpesquisarpor.SelectedIndex;
            if (i != -1)
            {
                string pesquisa = cbxpesquisarpor.SelectedItem.ToString();
                if(tbxpesquisa.Text.Length > 0) {
                    if (pesquisa.Equals("Id"))
                    {
                        int id = 0;
                        try
                        {
                            id = Convert.ToInt32(tbxpesquisa.Text);
                        }
                        catch(Exception)
                        {
                            MessageBox.Show("Insira valores numéricos");
                        }
                        pesquisarIdTipoSintoma(id);
                    }
                    else
                    {
                        string nome = tbxpesquisa.Text;
                        pesquisarNomeTipoSintoma(nome);
                    }
                }
                else
                {
                    atualizarTabela();
                }
            }
        }

        private void pesquisarNomeTipoSintoma(string nome)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM tipo_sintoma WHERE nome LIKE '%" + nome + "%'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvtiposdesintomas.DataSource = dt;
            if(dgvtiposdesintomas.RowCount == 0)
            {
                MessageBox.Show("Não existem dados com esse filtro.", "Pesquisa de dados");
            }
            con.Close();
        }

        private void pesquisarIdTipoSintoma(int id)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM tipo_sintoma WHERE Id = " + id;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvtiposdesintomas.DataSource = dt;
            if(dgvtiposdesintomas.RowCount == 0)
            {
                MessageBox.Show("Não existem dados com esse filtro.", "Pesquisa de dados");
            }
            con.Close();

            

            //atualizarTabela();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            limparDados();
        }

        private void limparDados()
        {
            tbxnome.ResetText();
            tbxdescricao.ResetText();
            cbxpesquisarpor.SelectedIndex = 0;
            label2.Text = "Id:";
            nova = true;
            atualizarTabela();
            btnapagar.Enabled = false;
        }

        private void FormTipoSintoma_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPrincipalMedico form = new FormPrincipalMedico(utilizador, idutilizador);
            form.Show();
        }
    }
}
