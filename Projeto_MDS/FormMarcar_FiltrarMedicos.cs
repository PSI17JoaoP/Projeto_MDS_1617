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
    public partial class FormMarcar_FiltrarMedicos : Form
    {
        List<Medicos> dados;
        FormMarcar marcar;

        public FormMarcar_FiltrarMedicos(List<Medicos> medicos, List<Especialidades> especialidades, FormMarcar form)
        {
            InitializeComponent();

            marcar = form;
            dados = medicos;

            foreach (Especialidades esp in especialidades)
            {
                cmbEspecialidades.Items.Add(esp.Nome);
            }

            PreencheLista("");
        }

        private void PreencheLista(string especialidade)
        {
            lvMedicos.Items.Clear();

            foreach (Medicos registo in dados)
            {
                if (registo.Especialidade.Contains(especialidade))
                {
                    lvMedicos.Items.Add(registo.Nome);
                }
            }
        }

        private void cmbEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreencheLista(cmbEspecialidades.SelectedItem.ToString());
        }

        private void lvMedicos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvMedicos.SelectedItems.Count > 0)
            {
                string nome = lvMedicos.SelectedItems[0].Text;
                marcar.MedicoPesquisado(nome);
                Close();
            }
        }
    }
}
