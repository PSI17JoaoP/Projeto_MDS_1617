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
    public partial class FormGestaoMedicos : Form
    {
        private FormMenu formMenu;

        public FormGestaoMedicos(FormMenu form)
        {
            InitializeComponent();

            formMenu = form;
        }

        private void BotaoAdicionarMedico(object sender, EventArgs e)
        {
            FormAdicionarMedico formAdicionarMedico = new FormAdicionarMedico(this);
            formAdicionarMedico.Show();
            Hide();
        }

        private void BotaoVoltarPrincipal(object sender, EventArgs e)
        {
            formMenu.Show();
            Hide();
        }
    }
}
