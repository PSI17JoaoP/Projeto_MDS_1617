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
    public partial class FormPrincipalMedico : Form
    {
        Utilizadores utilizador;
        int idutilizador;

        public FormPrincipalMedico(Utilizadores utilizador1, int idutilizador1)
        {
            InitializeComponent();
            utilizador = utilizador1;
            idutilizador = idutilizador1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTipoSintoma form = new FormTipoSintoma(utilizador, idutilizador);
            form.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMinhasConsultas form = new FormMinhasConsultas(utilizador, idutilizador);
            form.Show();
            Hide();
        }

        private void FormPrincipalMedico_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogin form = new FormLogin();
            form.Show();
            Hide();
        }
    }
}
