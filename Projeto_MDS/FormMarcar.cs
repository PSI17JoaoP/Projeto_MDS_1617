using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_MDS
{
    public partial class FormMarcar : Form
    {

        public FormMenu menu;

        public FormMarcar(FormMenu form)
        {
            InitializeComponent();

            menu = form;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMarcar_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Show();
        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                string nomeP = txtNome.Text;
                string data = dtpData.Text;
                string hora = txtHora.Text;
                string nomeM = txtMedico.Text;

                
                try
                {
                    Marcacao marcacao = new Marcacao(nomeP, data, hora, nomeM);

                    if (menu.AdicionarConsulta(marcacao))
                    {
                        MessageBox.Show("Marcação registada com sucesso!", "Sucesso", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao registar a marcação", "Erro", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }else
            {
                MessageBox.Show("Tem de preencher todos os campos");
            }

        }

        private bool VerificaCampos()
        {
            bool result = false;

            if (txtNome.Text.Length > 0 && txtMedico.Text.Length > 0 && !txtHora.Text.Equals("00:00"))
            {
                result = true;
            }

            return result;
        }

        private void txtMedico_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
