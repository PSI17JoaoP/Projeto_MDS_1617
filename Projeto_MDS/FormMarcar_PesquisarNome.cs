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
    public partial class FormMarcar_PesquisarNome : Form
    {
        List<Pacientes> dados;
        FormMarcar marcar;

        public FormMarcar_PesquisarNome(List<Pacientes> marcacoes, FormMarcar form)
        {
            InitializeComponent();

            marcar = form; 
            dados = marcacoes;

            PreencheLista("");
        }

        private void PreencheLista(string filtro)
        {
            lvPacientes.Items.Clear();

            foreach (Pacientes registo in dados)
            {
                if (registo.Nome.Contains(filtro))
                {
                    lvPacientes.Items.Add(registo.Nome);
                }
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            PreencheLista(txtNome.Text.Trim());
        }

        private void lvPacientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvPacientes.SelectedItems.Count > 0)
            {
                string nome = lvPacientes.SelectedItems[0].Text;
                marcar.NomePesquisado(nome);
                Close();
            }
        }
    }
}
