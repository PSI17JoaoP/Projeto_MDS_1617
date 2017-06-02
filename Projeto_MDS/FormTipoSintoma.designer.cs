namespace Projeto_MDS
{
    partial class FormTipoSintoma
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTipoSintoma));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnregistar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnnovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnapagar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxpesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxpesquisarpor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxdescricao = new System.Windows.Forms.TextBox();
            this.tbxnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvtiposdesintomas = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtiposdesintomas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnregistar,
            this.toolStripSeparator1,
            this.btnnovo,
            this.toolStripSeparator2,
            this.btnapagar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(598, 55);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
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
            // btnnovo
            // 
            this.btnnovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnnovo.Image = ((System.Drawing.Image)(resources.GetObject("btnnovo.Image")));
            this.btnnovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnnovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(52, 52);
            this.btnnovo.Text = "toolStripButton2";
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // btnapagar
            // 
            this.btnapagar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnapagar.Enabled = false;
            this.btnapagar.Image = ((System.Drawing.Image)(resources.GetObject("btnapagar.Image")));
            this.btnapagar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnapagar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnapagar.Name = "btnapagar";
            this.btnapagar.Size = new System.Drawing.Size(52, 52);
            this.btnapagar.Text = "toolStripButton3";
            this.btnapagar.Click += new System.EventHandler(this.btnapagar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxpesquisa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxpesquisarpor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caixa de Pesquisa";
            // 
            // tbxpesquisa
            // 
            this.tbxpesquisa.Location = new System.Drawing.Point(106, 53);
            this.tbxpesquisa.Name = "tbxpesquisa";
            this.tbxpesquisa.Size = new System.Drawing.Size(244, 20);
            this.tbxpesquisa.TabIndex = 3;
            this.tbxpesquisa.TextChanged += new System.EventHandler(this.tbxpesquisa_TextChanged);
            this.tbxpesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id:";
            // 
            // cbxpesquisarpor
            // 
            this.cbxpesquisarpor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxpesquisarpor.FormattingEnabled = true;
            this.cbxpesquisarpor.Items.AddRange(new object[] {
            "Id",
            "Nome"});
            this.cbxpesquisarpor.Location = new System.Drawing.Point(106, 24);
            this.cbxpesquisarpor.Name = "cbxpesquisarpor";
            this.cbxpesquisarpor.Size = new System.Drawing.Size(244, 21);
            this.cbxpesquisarpor.TabIndex = 1;
            this.cbxpesquisarpor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar por:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbxdescricao);
            this.groupBox2.Controls.Add(this.tbxnome);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 165);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descrição/Observações:";
            // 
            // tbxdescricao
            // 
            this.tbxdescricao.Location = new System.Drawing.Point(9, 66);
            this.tbxdescricao.Multiline = true;
            this.tbxdescricao.Name = "tbxdescricao";
            this.tbxdescricao.Size = new System.Drawing.Size(216, 88);
            this.tbxdescricao.TabIndex = 4;
            // 
            // tbxnome
            // 
            this.tbxnome.Location = new System.Drawing.Point(50, 19);
            this.tbxnome.Name = "tbxnome";
            this.tbxnome.Size = new System.Drawing.Size(175, 20);
            this.tbxnome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome:";
            // 
            // dgvtiposdesintomas
            // 
            this.dgvtiposdesintomas.AllowUserToAddRows = false;
            this.dgvtiposdesintomas.AllowUserToDeleteRows = false;
            this.dgvtiposdesintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtiposdesintomas.Location = new System.Drawing.Point(269, 164);
            this.dgvtiposdesintomas.Name = "dgvtiposdesintomas";
            this.dgvtiposdesintomas.ReadOnly = true;
            this.dgvtiposdesintomas.RowHeadersVisible = false;
            this.dgvtiposdesintomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtiposdesintomas.Size = new System.Drawing.Size(317, 165);
            this.dgvtiposdesintomas.TabIndex = 4;
            this.dgvtiposdesintomas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtiposdesintomas_CellClick);
            // 
            // FormTipoSintoma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 336);
            this.Controls.Add(this.dgvtiposdesintomas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "FormTipoSintoma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão  de Tipos de Sintomas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTipoSintoma_FormClosed);
            this.Load += new System.EventHandler(this.FormTipoSintoma_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtiposdesintomas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnregistar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnnovo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnapagar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxpesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxpesquisarpor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxdescricao;
        private System.Windows.Forms.TextBox tbxnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvtiposdesintomas;
    }
}