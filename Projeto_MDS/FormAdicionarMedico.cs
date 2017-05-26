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
    public partial class FormAdicionarMedico : Form
    {
        private FormGestaoMedicos formGestaoMedicos;

        public FormAdicionarMedico(FormGestaoMedicos form)
        {
            InitializeComponent();

            formGestaoMedicos = form;
        }

        private void BotaoSelecionarEspecialidade(object sender, EventArgs e)
        {
            FormSelecionarEspecialidade formSelecionarEspecialidade = new FormSelecionarEspecialidade(this);
            formSelecionarEspecialidade.Show();
            Hide();
        }

        private void BotaoAdicionarMedico(object sender, EventArgs e)
        {

        }

        private void BotaoCancelarMedico(object sender, EventArgs e)
        {
            formGestaoMedicos.Show();
            Hide();
        }
    }
}
