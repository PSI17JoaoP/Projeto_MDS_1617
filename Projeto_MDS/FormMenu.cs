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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();

            registosConsultas = new List<Consultas>();
        }

        //#######################
        //Listas para guardar os dados en runtime - facilitar a gestão

        List<Consultas> registosConsultas;

        //#######################


        private void btnMarcarConsulta_Click(object sender, EventArgs e)
        {
            FormMarcar form = new FormMarcar(this);
            form.Show();
            Hide();
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public bool AdicionarConsulta(Consultas consulta)
        {
            bool result;

            try
            {
                registosConsultas.Add(consulta);
                result = true;
            }
            catch (Exception)
            {
                result = false;
                throw;
            }
            
            return result;
        }
    }
}
