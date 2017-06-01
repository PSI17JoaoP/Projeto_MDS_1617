namespace Projeto_MDS
{
    partial class FormMarcar
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnMarcar = new System.Windows.Forms.Button();
            this.btnFiltrarMedico = new System.Windows.Forms.Button();
            this.btnPesquisarNome = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Médico";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(324, 215);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 30);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnMarcar
            // 
            this.btnMarcar.Location = new System.Drawing.Point(235, 215);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(83, 30);
            this.btnMarcar.TabIndex = 3;
            this.btnMarcar.Text = "Marcar";
            this.btnMarcar.UseVisualStyleBackColor = true;
            this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
            // 
            // btnFiltrarMedico
            // 
            this.btnFiltrarMedico.Location = new System.Drawing.Point(210, 157);
            this.btnFiltrarMedico.Name = "btnFiltrarMedico";
            this.btnFiltrarMedico.Size = new System.Drawing.Size(75, 30);
            this.btnFiltrarMedico.TabIndex = 4;
            this.btnFiltrarMedico.Text = "Filtrar";
            this.btnFiltrarMedico.UseVisualStyleBackColor = true;
            this.btnFiltrarMedico.Click += new System.EventHandler(this.btnFiltrarMedico_Click);
            // 
            // btnPesquisarNome
            // 
            this.btnPesquisarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarNome.Location = new System.Drawing.Point(277, 24);
            this.btnPesquisarNome.Name = "btnPesquisarNome";
            this.btnPesquisarNome.Size = new System.Drawing.Size(123, 31);
            this.btnPesquisarNome.TabIndex = 5;
            this.btnPesquisarNome.Text = "Pesquisar Nome";
            this.btnPesquisarNome.UseVisualStyleBackColor = true;
            this.btnPesquisarNome.Click += new System.EventHandler(this.btnPesquisarNome_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(77, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(194, 22);
            this.txtNome.TabIndex = 6;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(77, 86);
            this.dtpData.MinDate = new System.DateTime(2017, 5, 26, 0, 0, 0, 0);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(127, 22);
            this.dtpData.TabIndex = 7;
            // 
            // txtMedico
            // 
            this.txtMedico.Location = new System.Drawing.Point(77, 157);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(127, 22);
            this.txtMedico.TabIndex = 9;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(277, 86);
            this.txtHora.Mask = "00:00";
            this.txtHora.Name = "txtHora";
            this.txtHora.RejectInputOnFirstFailure = true;
            this.txtHora.Size = new System.Drawing.Size(52, 22);
            this.txtHora.TabIndex = 10;
            this.txtHora.Text = "0000";
            this.txtHora.ValidatingType = typeof(System.DateTime);
            // 
            // FormMarcar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 257);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtMedico);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnPesquisarNome);
            this.Controls.Add(this.btnFiltrarMedico);
            this.Controls.Add(this.btnMarcar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMarcar";
            this.Text = "FormMarcar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMarcar_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnMarcar;
        private System.Windows.Forms.Button btnFiltrarMedico;
        private System.Windows.Forms.Button btnPesquisarNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.MaskedTextBox txtHora;
    }
}