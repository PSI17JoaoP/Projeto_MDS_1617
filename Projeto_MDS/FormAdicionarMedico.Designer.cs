namespace Projeto_MDS
{
    partial class FormAdicionarMedico
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbHorario = new System.Windows.Forms.GroupBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbEspecialidade = new System.Windows.Forms.TextBox();
            this.tbNSS = new System.Windows.Forms.TextBox();
            this.btnSelecionarEspecialidade = new System.Windows.Forms.Button();
            this.btnAdicionarMedico = new System.Windows.Forms.Button();
            this.btnCancelarMedico = new System.Windows.Forms.Button();
            this.dtpHoraSaida = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mtbPassword = new System.Windows.Forms.MaskedTextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.gbHorario.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de Segurança Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Especialidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora de Entrada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hora de Saida";
            // 
            // gbHorario
            // 
            this.gbHorario.Controls.Add(this.dtpHoraSaida);
            this.gbHorario.Controls.Add(this.dtpHoraEntrada);
            this.gbHorario.Controls.Add(this.label4);
            this.gbHorario.Controls.Add(this.label5);
            this.gbHorario.Location = new System.Drawing.Point(17, 193);
            this.gbHorario.Name = "gbHorario";
            this.gbHorario.Size = new System.Drawing.Size(200, 100);
            this.gbHorario.TabIndex = 5;
            this.gbHorario.TabStop = false;
            this.gbHorario.Text = "Horario de Trabalho";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(56, 83);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(210, 20);
            this.tbNome.TabIndex = 6;
            // 
            // tbEspecialidade
            // 
            this.tbEspecialidade.Location = new System.Drawing.Point(93, 155);
            this.tbEspecialidade.Name = "tbEspecialidade";
            this.tbEspecialidade.ReadOnly = true;
            this.tbEspecialidade.Size = new System.Drawing.Size(173, 20);
            this.tbEspecialidade.TabIndex = 7;
            // 
            // tbNSS
            // 
            this.tbNSS.Location = new System.Drawing.Point(166, 118);
            this.tbNSS.MaxLength = 9;
            this.tbNSS.Name = "tbNSS";
            this.tbNSS.Size = new System.Drawing.Size(100, 20);
            this.tbNSS.TabIndex = 9;
            // 
            // btnSelecionarEspecialidade
            // 
            this.btnSelecionarEspecialidade.Location = new System.Drawing.Point(272, 153);
            this.btnSelecionarEspecialidade.Name = "btnSelecionarEspecialidade";
            this.btnSelecionarEspecialidade.Size = new System.Drawing.Size(140, 23);
            this.btnSelecionarEspecialidade.TabIndex = 10;
            this.btnSelecionarEspecialidade.Text = "Selecionar Especialidade";
            this.btnSelecionarEspecialidade.UseVisualStyleBackColor = true;
            this.btnSelecionarEspecialidade.Click += new System.EventHandler(this.BotaoSelecionarEspecialidade);
            // 
            // btnAdicionarMedico
            // 
            this.btnAdicionarMedico.Location = new System.Drawing.Point(230, 302);
            this.btnAdicionarMedico.Name = "btnAdicionarMedico";
            this.btnAdicionarMedico.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarMedico.TabIndex = 11;
            this.btnAdicionarMedico.Text = "Adicionar";
            this.btnAdicionarMedico.UseVisualStyleBackColor = true;
            this.btnAdicionarMedico.Click += new System.EventHandler(this.BotaoAdicionarMedico);
            // 
            // btnCancelarMedico
            // 
            this.btnCancelarMedico.Location = new System.Drawing.Point(322, 302);
            this.btnCancelarMedico.Name = "btnCancelarMedico";
            this.btnCancelarMedico.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarMedico.TabIndex = 12;
            this.btnCancelarMedico.Text = "Cancelar";
            this.btnCancelarMedico.UseVisualStyleBackColor = true;
            this.btnCancelarMedico.Click += new System.EventHandler(this.BotaoCancelarMedico);
            // 
            // dtpHoraSaida
            // 
            this.dtpHoraSaida.CustomFormat = "H:mm";
            this.dtpHoraSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraSaida.Location = new System.Drawing.Point(106, 58);
            this.dtpHoraSaida.Name = "dtpHoraSaida";
            this.dtpHoraSaida.ShowUpDown = true;
            this.dtpHoraSaida.Size = new System.Drawing.Size(79, 20);
            this.dtpHoraSaida.TabIndex = 13;
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.CustomFormat = "H:mm";
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(106, 23);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.ShowUpDown = true;
            this.dtpHoraEntrada.Size = new System.Drawing.Size(79, 20);
            this.dtpHoraEntrada.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Password";
            // 
            // mtbPassword
            // 
            this.mtbPassword.Location = new System.Drawing.Point(73, 48);
            this.mtbPassword.Name = "mtbPassword";
            this.mtbPassword.PasswordChar = '*';
            this.mtbPassword.Size = new System.Drawing.Size(193, 20);
            this.mtbPassword.TabIndex = 15;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(73, 19);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(193, 20);
            this.tbUsername.TabIndex = 16;
            // 
            // FormAdicionarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 361);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.mtbPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancelarMedico);
            this.Controls.Add(this.btnAdicionarMedico);
            this.Controls.Add(this.btnSelecionarEspecialidade);
            this.Controls.Add(this.tbNSS);
            this.Controls.Add(this.tbEspecialidade);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.gbHorario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAdicionarMedico";
            this.Text = "Janela de Inserção de Médicos";
            this.gbHorario.ResumeLayout(false);
            this.gbHorario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbHorario;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbEspecialidade;
        private System.Windows.Forms.TextBox tbNSS;
        private System.Windows.Forms.Button btnSelecionarEspecialidade;
        private System.Windows.Forms.Button btnAdicionarMedico;
        private System.Windows.Forms.Button btnCancelarMedico;
        private System.Windows.Forms.DateTimePicker dtpHoraSaida;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtbPassword;
        private System.Windows.Forms.TextBox tbUsername;
    }
}