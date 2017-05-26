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
            this.btnRegistarConsultaMedica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMarcarConsulta
            // 
            this.btnMarcarConsulta.Location = new System.Drawing.Point(11, 60);
            this.btnMarcarConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.btnMarcarConsulta.Name = "btnMarcarConsulta";
            this.btnMarcarConsulta.Size = new System.Drawing.Size(90, 36);
            this.btnMarcarConsulta.TabIndex = 0;
            this.btnMarcarConsulta.Text = "Marcar Consulta";
            this.btnMarcarConsulta.UseVisualStyleBackColor = true;
            this.btnMarcarConsulta.Click += new System.EventHandler(this.btnMarcarConsulta_Click);
            // 
            // btnPesquisarConsulta
            // 
            this.btnPesquisarConsulta.Enabled = false;
            this.btnPesquisarConsulta.Location = new System.Drawing.Point(115, 60);
            this.btnPesquisarConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisarConsulta.Name = "btnPesquisarConsulta";
            this.btnPesquisarConsulta.Size = new System.Drawing.Size(90, 36);
            this.btnPesquisarConsulta.TabIndex = 1;
            this.btnPesquisarConsulta.Text = "Pesquisar Consulta";
            this.btnPesquisarConsulta.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarMedico
            // 
            this.btnAdicionarMedico.Location = new System.Drawing.Point(218, 60);
            this.btnAdicionarMedico.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionarMedico.Name = "btnAdicionarMedico";
            this.btnAdicionarMedico.Size = new System.Drawing.Size(90, 36);
            this.btnAdicionarMedico.TabIndex = 2;
            this.btnAdicionarMedico.Text = "Adicionar Médico";
            this.btnAdicionarMedico.UseVisualStyleBackColor = true;
            this.btnAdicionarMedico.Click += new System.EventHandler(this.btnAdicionarMedico_Click);
            // 
            // btnGerirEspecialidades
            // 
            this.btnGerirEspecialidades.Enabled = false;
            this.btnGerirEspecialidades.Location = new System.Drawing.Point(323, 60);
            this.btnGerirEspecialidades.Margin = new System.Windows.Forms.Padding(2);
            this.btnGerirEspecialidades.Name = "btnGerirEspecialidades";
            this.btnGerirEspecialidades.Size = new System.Drawing.Size(126, 36);
            this.btnGerirEspecialidades.TabIndex = 3;
            this.btnGerirEspecialidades.Text = "Gerir Especialidades Médicas";
            this.btnGerirEspecialidades.UseVisualStyleBackColor = true;
            // 
            // btnConsultarPacientes
            // 
            this.btnConsultarPacientes.Enabled = false;
            this.btnConsultarPacientes.Location = new System.Drawing.Point(328, 17);
            this.btnConsultarPacientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarPacientes.Name = "btnConsultarPacientes";
            this.btnConsultarPacientes.Size = new System.Drawing.Size(122, 27);
            this.btnConsultarPacientes.TabIndex = 4;
            this.btnConsultarPacientes.Text = "Consultar Paciente ...";
            this.btnConsultarPacientes.UseVisualStyleBackColor = true;
            // 
            // btnRegistarConsultaMedica
            // 
            this.btnRegistarConsultaMedica.Location = new System.Drawing.Point(215, 12);
            this.btnRegistarConsultaMedica.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistarConsultaMedica.Name = "btnRegistarConsultaMedica";
            this.btnRegistarConsultaMedica.Size = new System.Drawing.Size(98, 36);
            this.btnRegistarConsultaMedica.TabIndex = 5;
            this.btnRegistarConsultaMedica.Text = "Registar Consulta Médica";
            this.btnRegistarConsultaMedica.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 107);
            this.Controls.Add(this.btnRegistarConsultaMedica);
            this.Controls.Add(this.btnConsultarPacientes);
            this.Controls.Add(this.btnGerirEspecialidades);
            this.Controls.Add(this.btnAdicionarMedico);
            this.Controls.Add(this.btnPesquisarConsulta);
            this.Controls.Add(this.btnMarcarConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenu_FormClosed);
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMarcarConsulta;
        private System.Windows.Forms.Button btnPesquisarConsulta;
        private System.Windows.Forms.Button btnAdicionarMedico;
        private System.Windows.Forms.Button btnGerirEspecialidades;
        private System.Windows.Forms.Button btnConsultarPacientes;
        private System.Windows.Forms.Button btnRegistarConsultaMedica;
    }
}

