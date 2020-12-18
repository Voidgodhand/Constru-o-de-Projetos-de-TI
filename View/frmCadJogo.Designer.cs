namespace View
{
    partial class frmCadJogo
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
            this.grbDadosPrincipais = new System.Windows.Forms.GroupBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDadosAdicionais = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ltbGenero = new System.Windows.Forms.ListBox();
            this.mtbLancamento = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbFranquia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grbDadosTecnicos = new System.Windows.Forms.GroupBox();
            this.cmbMidia = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ltbDev = new System.Windows.Forms.ListBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grbRelacionamentos = new System.Windows.Forms.GroupBox();
            this.ltbConsole = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grbDadosPrincipais.SuspendLayout();
            this.grbDadosAdicionais.SuspendLayout();
            this.grbDadosTecnicos.SuspendLayout();
            this.grbRelacionamentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDadosPrincipais
            // 
            this.grbDadosPrincipais.Controls.Add(this.txbNome);
            this.grbDadosPrincipais.Controls.Add(this.label3);
            this.grbDadosPrincipais.Controls.Add(this.txbCodigo);
            this.grbDadosPrincipais.Controls.Add(this.label1);
            this.grbDadosPrincipais.Location = new System.Drawing.Point(12, 13);
            this.grbDadosPrincipais.Name = "grbDadosPrincipais";
            this.grbDadosPrincipais.Size = new System.Drawing.Size(462, 100);
            this.grbDadosPrincipais.TabIndex = 0;
            this.grbDadosPrincipais.TabStop = false;
            this.grbDadosPrincipais.Text = "Dados Principais";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(317, 26);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(106, 20);
            this.txbNome.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome:";
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(123, 26);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(94, 20);
            this.txbCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // grbDadosAdicionais
            // 
            this.grbDadosAdicionais.Controls.Add(this.label8);
            this.grbDadosAdicionais.Controls.Add(this.ltbGenero);
            this.grbDadosAdicionais.Controls.Add(this.mtbLancamento);
            this.grbDadosAdicionais.Controls.Add(this.label7);
            this.grbDadosAdicionais.Controls.Add(this.label6);
            this.grbDadosAdicionais.Controls.Add(this.txbFranquia);
            this.grbDadosAdicionais.Controls.Add(this.label5);
            this.grbDadosAdicionais.Location = new System.Drawing.Point(12, 119);
            this.grbDadosAdicionais.Name = "grbDadosAdicionais";
            this.grbDadosAdicionais.Size = new System.Drawing.Size(462, 176);
            this.grbDadosAdicionais.TabIndex = 1;
            this.grbDadosAdicionais.TabStop = false;
            this.grbDadosAdicionais.Text = "Dados Adicionais";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Genero:";
            // 
            // ltbGenero
            // 
            this.ltbGenero.FormattingEnabled = true;
            this.ltbGenero.Items.AddRange(new object[] {
            "Acao e Aventura",
            "Plataforma",
            "Sandbox",
            "Tiro",
            "Luta",
            "RPG",
            "Real Time Strategy",
            "Stealth",
            "Survival Horror",
            "Metroidvania",
            "Battle Royale",
            "MOBA",
            "Tower Defense",
            "Hack\'n Slash",
            "Shoot\'em Up",
            "Beat\'em Up",
            "Run\'n Gun",
            "Corrida",
            "Esporte",
            "Simulacao",
            "Puzzle",
            "Board Game",
            "Card Game",
            "Trivia",
            "Party",
            "Light Gun",
            "Aventura em Texto",
            "Filme Interativo",
            "Visual Novel"});
            this.ltbGenero.Location = new System.Drawing.Point(123, 74);
            this.ltbGenero.Name = "ltbGenero";
            this.ltbGenero.Size = new System.Drawing.Size(135, 95);
            this.ltbGenero.TabIndex = 5;
            // 
            // mtbLancamento
            // 
            this.mtbLancamento.Location = new System.Drawing.Point(323, 35);
            this.mtbLancamento.Mask = "00/00/0000";
            this.mtbLancamento.Name = "mtbLancamento";
            this.mtbLancamento.Size = new System.Drawing.Size(100, 20);
            this.mtbLancamento.TabIndex = 4;
            this.mtbLancamento.ValidatingType = typeof(System.DateTime);
            this.mtbLancamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbLancamento_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Lancamento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 2;
            // 
            // txbFranquia
            // 
            this.txbFranquia.Location = new System.Drawing.Point(123, 32);
            this.txbFranquia.Name = "txbFranquia";
            this.txbFranquia.Size = new System.Drawing.Size(94, 20);
            this.txbFranquia.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Franquia:";
            // 
            // grbDadosTecnicos
            // 
            this.grbDadosTecnicos.Controls.Add(this.cmbMidia);
            this.grbDadosTecnicos.Controls.Add(this.label9);
            this.grbDadosTecnicos.Location = new System.Drawing.Point(12, 301);
            this.grbDadosTecnicos.Name = "grbDadosTecnicos";
            this.grbDadosTecnicos.Size = new System.Drawing.Size(184, 94);
            this.grbDadosTecnicos.TabIndex = 2;
            this.grbDadosTecnicos.TabStop = false;
            this.grbDadosTecnicos.Text = "Dados Tecnicos";
            // 
            // cmbMidia
            // 
            this.cmbMidia.FormattingEnabled = true;
            this.cmbMidia.Items.AddRange(new object[] {
            "Cartucho",
            "CD-ROM",
            "DVD-ROM",
            "Blu-Ray",
            "GD-ROM",
            "UMD",
            "Mini DVD",
            "Disquete",
            "Fita Cassete",
            "Laserdisc"});
            this.cmbMidia.Location = new System.Drawing.Point(54, 39);
            this.cmbMidia.Name = "cmbMidia";
            this.cmbMidia.Size = new System.Drawing.Size(121, 21);
            this.cmbMidia.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Midia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dev:";
            // 
            // ltbDev
            // 
            this.ltbDev.FormattingEnabled = true;
            this.ltbDev.Location = new System.Drawing.Point(47, 19);
            this.ltbDev.Name = "ltbDev";
            this.ltbDev.Size = new System.Drawing.Size(74, 69);
            this.ltbDev.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(311, 410);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(49, 410);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Visible = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(49, 410);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // grbRelacionamentos
            // 
            this.grbRelacionamentos.Controls.Add(this.ltbConsole);
            this.grbRelacionamentos.Controls.Add(this.label4);
            this.grbRelacionamentos.Controls.Add(this.label2);
            this.grbRelacionamentos.Controls.Add(this.ltbDev);
            this.grbRelacionamentos.Location = new System.Drawing.Point(202, 301);
            this.grbRelacionamentos.Name = "grbRelacionamentos";
            this.grbRelacionamentos.Size = new System.Drawing.Size(272, 100);
            this.grbRelacionamentos.TabIndex = 11;
            this.grbRelacionamentos.TabStop = false;
            this.grbRelacionamentos.Text = "Relacionamentos";
            // 
            // ltbConsole
            // 
            this.ltbConsole.FormattingEnabled = true;
            this.ltbConsole.Location = new System.Drawing.Point(187, 19);
            this.ltbConsole.Name = "ltbConsole";
            this.ltbConsole.Size = new System.Drawing.Size(79, 69);
            this.ltbConsole.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Console:";
            // 
            // frmCadJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 455);
            this.Controls.Add(this.grbRelacionamentos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbDadosTecnicos);
            this.Controls.Add(this.grbDadosAdicionais);
            this.Controls.Add(this.grbDadosPrincipais);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCadJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo Cadastro";
            this.Load += new System.EventHandler(this.frmCadJogo_Load);
            this.grbDadosPrincipais.ResumeLayout(false);
            this.grbDadosPrincipais.PerformLayout();
            this.grbDadosAdicionais.ResumeLayout(false);
            this.grbDadosAdicionais.PerformLayout();
            this.grbDadosTecnicos.ResumeLayout(false);
            this.grbDadosTecnicos.PerformLayout();
            this.grbRelacionamentos.ResumeLayout(false);
            this.grbRelacionamentos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDadosPrincipais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.GroupBox grbDadosAdicionais;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbFranquia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtbLancamento;
        private System.Windows.Forms.ListBox ltbGenero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grbDadosTecnicos;
        private System.Windows.Forms.ComboBox cmbMidia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ListBox ltbDev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbRelacionamentos;
        private System.Windows.Forms.ListBox ltbConsole;
        private System.Windows.Forms.Label label4;
    }
}