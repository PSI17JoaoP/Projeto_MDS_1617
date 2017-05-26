namespace Projeto_MDS
{
    partial class FormSelecionarEspecialidade
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
            this.gbListaEspecialidades = new System.Windows.Forms.GroupBox();
            this.lvListaEspecialidades = new System.Windows.Forms.ListView();
            this.btnSelecionarEspecialidade = new System.Windows.Forms.Button();
            this.btnCancelarEspecialidades = new System.Windows.Forms.Button();
            this.lvListaEspecialidadesIdCollumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvListaEspecialidadeNomeCollumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbListaEspecialidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListaEspecialidades
            // 
            this.gbListaEspecialidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListaEspecialidades.Controls.Add(this.lvListaEspecialidades);
            this.gbListaEspecialidades.Location = new System.Drawing.Point(12, 12);
            this.gbListaEspecialidades.Name = "gbListaEspecialidades";
            this.gbListaEspecialidades.Size = new System.Drawing.Size(337, 355);
            this.gbListaEspecialidades.TabIndex = 0;
            this.gbListaEspecialidades.TabStop = false;
            this.gbListaEspecialidades.Text = "Especialidades";
            // 
            // lvListaEspecialidades
            // 
            this.lvListaEspecialidades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvListaEspecialidadesIdCollumn,
            this.lvListaEspecialidadeNomeCollumn});
            this.lvListaEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvListaEspecialidades.FullRowSelect = true;
            this.lvListaEspecialidades.Location = new System.Drawing.Point(3, 16);
            this.lvListaEspecialidades.MultiSelect = false;
            this.lvListaEspecialidades.Name = "lvListaEspecialidades";
            this.lvListaEspecialidades.Size = new System.Drawing.Size(331, 336);
            this.lvListaEspecialidades.TabIndex = 0;
            this.lvListaEspecialidades.UseCompatibleStateImageBehavior = false;
            this.lvListaEspecialidades.View = System.Windows.Forms.View.Details;
            // 
            // btnSelecionarEspecialidade
            // 
            this.btnSelecionarEspecialidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionarEspecialidade.Location = new System.Drawing.Point(174, 393);
            this.btnSelecionarEspecialidade.Name = "btnSelecionarEspecialidade";
            this.btnSelecionarEspecialidade.Size = new System.Drawing.Size(84, 29);
            this.btnSelecionarEspecialidade.TabIndex = 2;
            this.btnSelecionarEspecialidade.Text = "Selecionar";
            this.btnSelecionarEspecialidade.UseVisualStyleBackColor = true;
            this.btnSelecionarEspecialidade.Click += new System.EventHandler(this.BotaoSelecionarEspecialidade);
            // 
            // btnCancelarEspecialidades
            // 
            this.btnCancelarEspecialidades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarEspecialidades.Location = new System.Drawing.Point(264, 393);
            this.btnCancelarEspecialidades.Name = "btnCancelarEspecialidades";
            this.btnCancelarEspecialidades.Size = new System.Drawing.Size(75, 29);
            this.btnCancelarEspecialidades.TabIndex = 3;
            this.btnCancelarEspecialidades.Text = "Cancelar";
            this.btnCancelarEspecialidades.UseVisualStyleBackColor = true;
            this.btnCancelarEspecialidades.Click += new System.EventHandler(this.BotaoCancelarEspecialidade);
            // 
            // lvListaEspecialidadesIdCollumn
            // 
            this.lvListaEspecialidadesIdCollumn.Text = "Id";
            this.lvListaEspecialidadesIdCollumn.Width = 25;
            // 
            // lvListaEspecialidadeNomeCollumn
            // 
            this.lvListaEspecialidadeNomeCollumn.Text = "Nome";
            this.lvListaEspecialidadeNomeCollumn.Width = 250;
            // 
            // FormSelecionarEspecialidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 432);
            this.Controls.Add(this.btnCancelarEspecialidades);
            this.Controls.Add(this.btnSelecionarEspecialidade);
            this.Controls.Add(this.gbListaEspecialidades);
            this.MinimumSize = new System.Drawing.Size(379, 470);
            this.Name = "FormSelecionarEspecialidade";
            this.Text = "Janela de Listagem de Especialidades";
            this.Load += new System.EventHandler(this.FormSelecionarEspecialidade_Load);
            this.gbListaEspecialidades.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListaEspecialidades;
        private System.Windows.Forms.Button btnSelecionarEspecialidade;
        private System.Windows.Forms.Button btnCancelarEspecialidades;
        private System.Windows.Forms.ListView lvListaEspecialidades;
        private System.Windows.Forms.ColumnHeader lvListaEspecialidadesIdCollumn;
        private System.Windows.Forms.ColumnHeader lvListaEspecialidadeNomeCollumn;
    }
}