namespace Projeto_MDS
{
    partial class FormGestaoMedicos
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
            this.gbListaMedicos = new System.Windows.Forms.GroupBox();
            this.lvListaMedicos = new System.Windows.Forms.ListView();
            this.lvcGestaoMedicosNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcGestaoMedicosEspecialidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcGestaoMedicosNiss = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcGestaoMedicosHoraEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcGestaoMedicosHoraSaida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbDetalhesMedico = new System.Windows.Forms.GroupBox();
            this.lvDetalhesMedico = new System.Windows.Forms.ListView();
            this.btnVoltarPrincipal = new System.Windows.Forms.Button();
            this.btnAdicionarMedico = new System.Windows.Forms.Button();
            this.gbListaMedicos.SuspendLayout();
            this.gbDetalhesMedico.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListaMedicos
            // 
            this.gbListaMedicos.Controls.Add(this.lvListaMedicos);
            this.gbListaMedicos.Location = new System.Drawing.Point(122, 96);
            this.gbListaMedicos.Name = "gbListaMedicos";
            this.gbListaMedicos.Size = new System.Drawing.Size(292, 358);
            this.gbListaMedicos.TabIndex = 0;
            this.gbListaMedicos.TabStop = false;
            this.gbListaMedicos.Text = "Médicos";
            // 
            // lvListaMedicos
            // 
            this.lvListaMedicos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvcGestaoMedicosNome,
            this.lvcGestaoMedicosEspecialidade,
            this.lvcGestaoMedicosNiss,
            this.lvcGestaoMedicosHoraEntrada,
            this.lvcGestaoMedicosHoraSaida});
            this.lvListaMedicos.FullRowSelect = true;
            this.lvListaMedicos.Location = new System.Drawing.Point(6, 19);
            this.lvListaMedicos.Name = "lvListaMedicos";
            this.lvListaMedicos.Size = new System.Drawing.Size(280, 333);
            this.lvListaMedicos.TabIndex = 0;
            this.lvListaMedicos.UseCompatibleStateImageBehavior = false;
            this.lvListaMedicos.View = System.Windows.Forms.View.Details;
            // 
            // lvcGestaoMedicosNome
            // 
            this.lvcGestaoMedicosNome.Text = "Nome";
            // 
            // lvcGestaoMedicosEspecialidade
            // 
            this.lvcGestaoMedicosEspecialidade.Text = "Especialidade";
            // 
            // lvcGestaoMedicosNiss
            // 
            this.lvcGestaoMedicosNiss.Text = "NISS";
            // 
            // lvcGestaoMedicosHoraEntrada
            // 
            this.lvcGestaoMedicosHoraEntrada.Text = "Hora de Entrada";
            // 
            // lvcGestaoMedicosHoraSaida
            // 
            this.lvcGestaoMedicosHoraSaida.Text = "Hora de Saida";
            // 
            // gbDetalhesMedico
            // 
            this.gbDetalhesMedico.Controls.Add(this.lvDetalhesMedico);
            this.gbDetalhesMedico.Location = new System.Drawing.Point(420, 96);
            this.gbDetalhesMedico.Name = "gbDetalhesMedico";
            this.gbDetalhesMedico.Size = new System.Drawing.Size(200, 358);
            this.gbDetalhesMedico.TabIndex = 1;
            this.gbDetalhesMedico.TabStop = false;
            this.gbDetalhesMedico.Text = "Detalhes";
            // 
            // lvDetalhesMedico
            // 
            this.lvDetalhesMedico.Location = new System.Drawing.Point(6, 19);
            this.lvDetalhesMedico.Name = "lvDetalhesMedico";
            this.lvDetalhesMedico.Size = new System.Drawing.Size(188, 333);
            this.lvDetalhesMedico.TabIndex = 1;
            this.lvDetalhesMedico.UseCompatibleStateImageBehavior = false;
            // 
            // btnVoltarPrincipal
            // 
            this.btnVoltarPrincipal.Location = new System.Drawing.Point(457, 39);
            this.btnVoltarPrincipal.Name = "btnVoltarPrincipal";
            this.btnVoltarPrincipal.Size = new System.Drawing.Size(157, 28);
            this.btnVoltarPrincipal.TabIndex = 2;
            this.btnVoltarPrincipal.Text = "Voltar ao Menu Principal";
            this.btnVoltarPrincipal.UseVisualStyleBackColor = true;
            this.btnVoltarPrincipal.Click += new System.EventHandler(this.BotaoVoltarPrincipal);
            // 
            // btnAdicionarMedico
            // 
            this.btnAdicionarMedico.Location = new System.Drawing.Point(21, 151);
            this.btnAdicionarMedico.Name = "btnAdicionarMedico";
            this.btnAdicionarMedico.Size = new System.Drawing.Size(75, 27);
            this.btnAdicionarMedico.TabIndex = 3;
            this.btnAdicionarMedico.Text = "Adicionar";
            this.btnAdicionarMedico.UseVisualStyleBackColor = true;
            this.btnAdicionarMedico.Click += new System.EventHandler(this.BotaoAdicionarMedico);
            // 
            // FormGestaoMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 466);
            this.Controls.Add(this.btnAdicionarMedico);
            this.Controls.Add(this.btnVoltarPrincipal);
            this.Controls.Add(this.gbDetalhesMedico);
            this.Controls.Add(this.gbListaMedicos);
            this.Name = "FormGestaoMedicos";
            this.Text = "Janela de Gestão de Médicos";
            this.Load += new System.EventHandler(this.FormGestaoMedicos_Load);
            this.gbListaMedicos.ResumeLayout(false);
            this.gbDetalhesMedico.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListaMedicos;
        private System.Windows.Forms.GroupBox gbDetalhesMedico;
        private System.Windows.Forms.Button btnVoltarPrincipal;
        private System.Windows.Forms.Button btnAdicionarMedico;
        private System.Windows.Forms.ListView lvDetalhesMedico;
        private System.Windows.Forms.ListView lvListaMedicos;
        private System.Windows.Forms.ColumnHeader lvcGestaoMedicosNome;
        private System.Windows.Forms.ColumnHeader lvcGestaoMedicosEspecialidade;
        private System.Windows.Forms.ColumnHeader lvcGestaoMedicosNiss;
        private System.Windows.Forms.ColumnHeader lvcGestaoMedicosHoraEntrada;
        private System.Windows.Forms.ColumnHeader lvcGestaoMedicosHoraSaida;
    }
}