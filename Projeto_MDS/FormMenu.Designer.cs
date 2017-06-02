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
            this.btnAdicionarMedico = new System.Windows.Forms.Button();
            this.btnConsultarPacientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMarcarConsulta
            // 
            this.btnMarcarConsulta.Location = new System.Drawing.Point(126, 20);
            this.btnMarcarConsulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMarcarConsulta.Name = "btnMarcarConsulta";
            this.btnMarcarConsulta.Size = new System.Drawing.Size(100, 89);
            this.btnMarcarConsulta.TabIndex = 0;
            this.btnMarcarConsulta.Text = "Marcar Consulta";
            this.btnMarcarConsulta.UseVisualStyleBackColor = true;
            this.btnMarcarConsulta.Click += new System.EventHandler(this.btnMarcarConsulta_Click);
            // 
            // btnAdicionarMedico
            // 
            this.btnAdicionarMedico.Location = new System.Drawing.Point(11, 20);
            this.btnAdicionarMedico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdicionarMedico.Name = "btnAdicionarMedico";
            this.btnAdicionarMedico.Size = new System.Drawing.Size(100, 89);
            this.btnAdicionarMedico.TabIndex = 2;
            this.btnAdicionarMedico.Text = "Adicionar Médico";
            this.btnAdicionarMedico.UseVisualStyleBackColor = true;
            this.btnAdicionarMedico.Click += new System.EventHandler(this.btnAdicionarMedico_Click);
            // 
            // btnConsultarPacientes
            // 
            this.btnConsultarPacientes.Location = new System.Drawing.Point(239, 20);
            this.btnConsultarPacientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarPacientes.Name = "btnConsultarPacientes";
            this.btnConsultarPacientes.Size = new System.Drawing.Size(100, 89);
            this.btnConsultarPacientes.TabIndex = 4;
            this.btnConsultarPacientes.Text = "Consultar Pacientes";
            this.btnConsultarPacientes.UseVisualStyleBackColor = true;
            this.btnConsultarPacientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 121);
            this.Controls.Add(this.btnConsultarPacientes);
            this.Controls.Add(this.btnAdicionarMedico);
            this.Controls.Add(this.btnMarcarConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenu_FormClosed);
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMarcarConsulta;
        private System.Windows.Forms.Button btnAdicionarMedico;
        private System.Windows.Forms.Button btnConsultarPacientes;
    }
}

