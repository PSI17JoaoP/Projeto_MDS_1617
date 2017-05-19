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
            this.gbDetalhesEspecialidade = new System.Windows.Forms.GroupBox();
            this.btnSelecionarEspecialidade = new System.Windows.Forms.Button();
            this.btnCancelarEspecialidades = new System.Windows.Forms.Button();
            this.lvListaEspecialidades = new System.Windows.Forms.ListView();
            this.lvDetalhesEspecialidade = new System.Windows.Forms.ListView();
            this.gbListaEspecialidades.SuspendLayout();
            this.gbDetalhesEspecialidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListaEspecialidades
            // 
            this.gbListaEspecialidades.Controls.Add(this.lvListaEspecialidades);
            this.gbListaEspecialidades.Location = new System.Drawing.Point(12, 12);
            this.gbListaEspecialidades.Name = "gbListaEspecialidades";
            this.gbListaEspecialidades.Size = new System.Drawing.Size(333, 355);
            this.gbListaEspecialidades.TabIndex = 0;
            this.gbListaEspecialidades.TabStop = false;
            this.gbListaEspecialidades.Text = "Especialidades";
            // 
            // gbDetalhesEspecialidade
            // 
            this.gbDetalhesEspecialidade.Controls.Add(this.lvDetalhesEspecialidade);
            this.gbDetalhesEspecialidade.Location = new System.Drawing.Point(351, 12);
            this.gbDetalhesEspecialidade.Name = "gbDetalhesEspecialidade";
            this.gbDetalhesEspecialidade.Size = new System.Drawing.Size(225, 252);
            this.gbDetalhesEspecialidade.TabIndex = 1;
            this.gbDetalhesEspecialidade.TabStop = false;
            this.gbDetalhesEspecialidade.Text = "Detalhes";
            // 
            // btnSelecionarEspecialidade
            // 
            this.btnSelecionarEspecialidade.Location = new System.Drawing.Point(386, 301);
            this.btnSelecionarEspecialidade.Name = "btnSelecionarEspecialidade";
            this.btnSelecionarEspecialidade.Size = new System.Drawing.Size(84, 29);
            this.btnSelecionarEspecialidade.TabIndex = 2;
            this.btnSelecionarEspecialidade.Text = "Selecionar";
            this.btnSelecionarEspecialidade.UseVisualStyleBackColor = true;
            // 
            // btnCancelarEspecialidades
            // 
            this.btnCancelarEspecialidades.Location = new System.Drawing.Point(476, 301);
            this.btnCancelarEspecialidades.Name = "btnCancelarEspecialidades";
            this.btnCancelarEspecialidades.Size = new System.Drawing.Size(75, 29);
            this.btnCancelarEspecialidades.TabIndex = 3;
            this.btnCancelarEspecialidades.Text = "Cancelar";
            this.btnCancelarEspecialidades.UseVisualStyleBackColor = true;
            // 
            // lvListaEspecialidades
            // 
            this.lvListaEspecialidades.Location = new System.Drawing.Point(6, 19);
            this.lvListaEspecialidades.Name = "lvListaEspecialidades";
            this.lvListaEspecialidades.Size = new System.Drawing.Size(321, 330);
            this.lvListaEspecialidades.TabIndex = 0;
            this.lvListaEspecialidades.UseCompatibleStateImageBehavior = false;
            // 
            // lvDetalhesEspecialidade
            // 
            this.lvDetalhesEspecialidade.Location = new System.Drawing.Point(6, 19);
            this.lvDetalhesEspecialidade.Name = "lvDetalhesEspecialidade";
            this.lvDetalhesEspecialidade.Size = new System.Drawing.Size(213, 227);
            this.lvDetalhesEspecialidade.TabIndex = 1;
            this.lvDetalhesEspecialidade.UseCompatibleStateImageBehavior = false;
            // 
            // FormSelecionarEspecialidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 379);
            this.Controls.Add(this.btnCancelarEspecialidades);
            this.Controls.Add(this.btnSelecionarEspecialidade);
            this.Controls.Add(this.gbDetalhesEspecialidade);
            this.Controls.Add(this.gbListaEspecialidades);
            this.Name = "FormSelecionarEspecialidade";
            this.Text = "Janela de Listagem de Especialidades";
            this.gbListaEspecialidades.ResumeLayout(false);
            this.gbDetalhesEspecialidade.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListaEspecialidades;
        private System.Windows.Forms.GroupBox gbDetalhesEspecialidade;
        private System.Windows.Forms.Button btnSelecionarEspecialidade;
        private System.Windows.Forms.Button btnCancelarEspecialidades;
        private System.Windows.Forms.ListView lvListaEspecialidades;
        private System.Windows.Forms.ListView lvDetalhesEspecialidade;
    }
}