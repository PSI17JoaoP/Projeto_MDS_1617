namespace Projeto_MDS
{
    partial class FormConsultaMedica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaMedica));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxdescricao = new System.Windows.Forms.TextBox();
            this.tbxnomepaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxhora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxdata = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxmedicamentos = new System.Windows.Forms.TextBox();
            this.tbxdescricaosintomas = new System.Windows.Forms.TextBox();
            this.cmbtiposintoma = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnregistar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxdescricao);
            this.groupBox1.Controls.Add(this.tbxnomepaciente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxhora);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxdata);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 120);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Gerais da Consulta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descricao/Observações";
            // 
            // tbxdescricao
            // 
            this.tbxdescricao.Enabled = false;
            this.tbxdescricao.Location = new System.Drawing.Point(20, 72);
            this.tbxdescricao.Multiline = true;
            this.tbxdescricao.Name = "tbxdescricao";
            this.tbxdescricao.Size = new System.Drawing.Size(528, 42);
            this.tbxdescricao.TabIndex = 6;
            // 
            // tbxnomepaciente
            // 
            this.tbxnomepaciente.Enabled = false;
            this.tbxnomepaciente.Location = new System.Drawing.Point(310, 23);
            this.tbxnomepaciente.Name = "tbxnomepaciente";
            this.tbxnomepaciente.Size = new System.Drawing.Size(238, 20);
            this.tbxnomepaciente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Paciente:";
            // 
            // tbxhora
            // 
            this.tbxhora.Enabled = false;
            this.tbxhora.Location = new System.Drawing.Point(182, 23);
            this.tbxhora.Name = "tbxhora";
            this.tbxhora.Size = new System.Drawing.Size(64, 20);
            this.tbxhora.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hora:";
            // 
            // tbxdata
            // 
            this.tbxdata.Enabled = false;
            this.tbxdata.Location = new System.Drawing.Point(56, 23);
            this.tbxdata.Name = "tbxdata";
            this.tbxdata.Size = new System.Drawing.Size(90, 20);
            this.tbxdata.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbxmedicamentos);
            this.groupBox2.Controls.Add(this.tbxdescricaosintomas);
            this.groupBox2.Controls.Add(this.cmbtiposintoma);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 209);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Medicação/Tratamentos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Descrição de sintomas";
            // 
            // tbxmedicamentos
            // 
            this.tbxmedicamentos.Location = new System.Drawing.Point(20, 140);
            this.tbxmedicamentos.Multiline = true;
            this.tbxmedicamentos.Name = "tbxmedicamentos";
            this.tbxmedicamentos.Size = new System.Drawing.Size(528, 55);
            this.tbxmedicamentos.TabIndex = 3;
            // 
            // tbxdescricaosintomas
            // 
            this.tbxdescricaosintomas.Location = new System.Drawing.Point(20, 68);
            this.tbxdescricaosintomas.Multiline = true;
            this.tbxdescricaosintomas.Name = "tbxdescricaosintomas";
            this.tbxdescricaosintomas.Size = new System.Drawing.Size(528, 53);
            this.tbxdescricaosintomas.TabIndex = 2;
            // 
            // cmbtiposintoma
            // 
            this.cmbtiposintoma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtiposintoma.FormattingEnabled = true;
            this.cmbtiposintoma.Location = new System.Drawing.Point(110, 22);
            this.cmbtiposintoma.Name = "cmbtiposintoma";
            this.cmbtiposintoma.Size = new System.Drawing.Size(239, 21);
            this.cmbtiposintoma.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipo de Sintoma:";
            // 
            // btnregistar
            // 
            this.btnregistar.Image = ((System.Drawing.Image)(resources.GetObject("btnregistar.Image")));
            this.btnregistar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnregistar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnregistar.Name = "btnregistar";
            this.btnregistar.Size = new System.Drawing.Size(52, 52);
            this.btnregistar.Click += new System.EventHandler(this.btnregistar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnregistar,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(585, 55);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FormConsultaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 400);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "FormConsultaMedica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Consulta Médica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormConsultaMedica_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxnomepaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxhora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxdata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxdescricao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxmedicamentos;
        private System.Windows.Forms.TextBox tbxdescricaosintomas;
        private System.Windows.Forms.ComboBox cmbtiposintoma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton btnregistar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}