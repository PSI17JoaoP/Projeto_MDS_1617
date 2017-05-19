namespace Projeto_MDS
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMarcarConsulta = new System.Windows.Forms.Button();
            this.btnPesquisarConsulta = new System.Windows.Forms.Button();
            this.btnAdicionarMedico = new System.Windows.Forms.Button();
            this.btnGerirEspecialidades = new System.Windows.Forms.Button();
            this.btnConsultarPacientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMarcarConsulta
            // 
            this.btnMarcarConsulta.Location = new System.Drawing.Point(191, 79);
            this.btnMarcarConsulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMarcarConsulta.Name = "btnMarcarConsulta";
            this.btnMarcarConsulta.Size = new System.Drawing.Size(77, 36);
            this.btnMarcarConsulta.TabIndex = 0;
            this.btnMarcarConsulta.Text = "Marcar Consulta";
            this.btnMarcarConsulta.UseVisualStyleBackColor = true;
            this.btnMarcarConsulta.Click += new System.EventHandler(this.btnMarcarConsulta_Click);
            // 
            // btnPesquisarConsulta
            // 
            this.btnPesquisarConsulta.Location = new System.Drawing.Point(191, 21);
            this.btnPesquisarConsulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPesquisarConsulta.Name = "btnPesquisarConsulta";
            this.btnPesquisarConsulta.Size = new System.Drawing.Size(77, 36);
            this.btnPesquisarConsulta.TabIndex = 1;
            this.btnPesquisarConsulta.Text = "Pesquisar Consulta";
            this.btnPesquisarConsulta.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarMedico
            // 
            this.btnAdicionarMedico.Location = new System.Drawing.Point(21, 21);
            this.btnAdicionarMedico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdicionarMedico.Name = "btnAdicionarMedico";
            this.btnAdicionarMedico.Size = new System.Drawing.Size(77, 36);
            this.btnAdicionarMedico.TabIndex = 2;
            this.btnAdicionarMedico.Text = "Adicionar Médico";
            this.btnAdicionarMedico.UseVisualStyleBackColor = true;
            // 
            // btnGerirEspecialidades
            // 
            this.btnGerirEspecialidades.Location = new System.Drawing.Point(21, 79);
            this.btnGerirEspecialidades.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGerirEspecialidades.Name = "btnGerirEspecialidades";
            this.btnGerirEspecialidades.Size = new System.Drawing.Size(126, 36);
            this.btnGerirEspecialidades.TabIndex = 3;
            this.btnGerirEspecialidades.Text = "Gerir Especialidades Médicas";
            this.btnGerirEspecialidades.UseVisualStyleBackColor = true;
            // 
            // btnConsultarPacientes
            // 
            this.btnConsultarPacientes.Location = new System.Drawing.Point(21, 140);
            this.btnConsultarPacientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsultarPacientes.Name = "btnConsultarPacientes";
            this.btnConsultarPacientes.Size = new System.Drawing.Size(126, 36);
            this.btnConsultarPacientes.TabIndex = 4;
            this.btnConsultarPacientes.Text = "Consultar Paciente";
            this.btnConsultarPacientes.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 190);
            this.Controls.Add(this.btnConsultarPacientes);
            this.Controls.Add(this.btnGerirEspecialidades);
            this.Controls.Add(this.btnAdicionarMedico);
            this.Controls.Add(this.btnPesquisarConsulta);
            this.Controls.Add(this.btnMarcarConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMarcarConsulta;
        private System.Windows.Forms.Button btnPesquisarConsulta;
        private System.Windows.Forms.Button btnAdicionarMedico;
        private System.Windows.Forms.Button btnGerirEspecialidades;
        private System.Windows.Forms.Button btnConsultarPacientes;
    }
}

