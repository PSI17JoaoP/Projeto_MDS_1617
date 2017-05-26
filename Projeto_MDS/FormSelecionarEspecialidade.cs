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
    public partial class FormSelecionarEspecialidade : Form
    {
        private FormAdicionarMedico formAdicionarMedico;

        public FormSelecionarEspecialidade(FormAdicionarMedico form)
        {
            InitializeComponent();

            formAdicionarMedico = form;
        }

        private void BotaoSelecionarEspecialidade(object sender, EventArgs e)
        {

        }

        private void BotaoCancelarEspecialidade(object sender, EventArgs e)
        {
            formAdicionarMedico.Show();
            Hide();
        }
    }
}
