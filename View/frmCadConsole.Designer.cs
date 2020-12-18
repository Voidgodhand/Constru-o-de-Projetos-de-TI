namespace View
{
    partial class frmCadConsole
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
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbFabricante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDadosTempo = new System.Windows.Forms.GroupBox();
            this.ltbGeracao = new System.Windows.Forms.ListBox();
            this.mtbLancamento = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grbDadosTecnicos = new System.Windows.Forms.GroupBox();
            this.grbTravaRegiao = new System.Windows.Forms.GroupBox();
            this.ckbLogica = new System.Windows.Forms.CheckBox();
            this.ckbFisica = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.grbDadosPrincipais.SuspendLayout();
            this.grbDadosTempo.SuspendLayout();
            this.grbDadosTecnicos.SuspendLayout();
            this.grbTravaRegiao.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDadosPrincipais
            // 
            this.grbDadosPrincipais.Controls.Add(this.cmbTipo);
            this.grbDadosPrincipais.Controls.Add(this.label4);
            this.grbDadosPrincipais.Controls.Add(this.txbFabricante);
            this.grbDadosPrincipais.Controls.Add(this.label3);
            this.grbDadosPrincipais.Controls.Add(this.txbNome);
            this.grbDadosPrincipais.Controls.Add(this.label2);
            this.grbDadosPrincipais.Controls.Add(this.txbNumero);
            this.grbDadosPrincipais.Controls.Add(this.label1);
            this.grbDadosPrincipais.Location = new System.Drawing.Point(12, 13);
            this.grbDadosPrincipais.Name = "grbDadosPrincipais";
            this.grbDadosPrincipais.Size = new System.Drawing.Size(462, 101);
            this.grbDadosPrincipais.TabIndex = 0;
            this.grbDadosPrincipais.TabStop = false;
            this.grbDadosPrincipais.Text = "Dados Principais";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "De mesa",
            "Portatil",
            "Hibrido"});
            this.cmbTipo.Location = new System.Drawing.Point(297, 65);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo:";
            // 
            // txbFabricante
            // 
            this.txbFabricante.Location = new System.Drawing.Point(114, 62);
            this.txbFabricante.Name = "txbFabricante";
            this.txbFabricante.Size = new System.Drawing.Size(100, 20);
            this.txbFabricante.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fabricante:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(297, 28);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(110, 28);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(100, 20);
            this.txbNumero.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero:";
            // 
            // grbDadosTempo
            // 
            this.grbDadosTempo.Controls.Add(this.ltbGeracao);
            this.grbDadosTempo.Controls.Add(this.mtbLancamento);
            this.grbDadosTempo.Controls.Add(this.label5);
            this.grbDadosTempo.Controls.Add(this.label6);
            this.grbDadosTempo.Location = new System.Drawing.Point(12, 120);
            this.grbDadosTempo.Name = "grbDadosTempo";
            this.grbDadosTempo.Size = new System.Drawing.Size(468, 113);
            this.grbDadosTempo.TabIndex = 1;
            this.grbDadosTempo.TabStop = false;
            this.grbDadosTempo.Text = "Dados de Tempo";
            // 
            // ltbGeracao
            // 
            this.ltbGeracao.FormattingEnabled = true;
            this.ltbGeracao.Items.AddRange(new object[] {
            "1ª",
            "2ª",
            "3ª",
            "4ª",
            "5ª",
            "6ª",
            "7ª",
            "8ª",
            "9ª"});
            this.ltbGeracao.Location = new System.Drawing.Point(310, 19);
            this.ltbGeracao.Name = "ltbGeracao";
            this.ltbGeracao.Size = new System.Drawing.Size(41, 82);
            this.ltbGeracao.TabIndex = 1;
            // 
            // mtbLancamento
            // 
            this.mtbLancamento.Location = new System.Drawing.Point(110, 31);
            this.mtbLancamento.Mask = "00/00/0000";
            this.mtbLancamento.Name = "mtbLancamento";
            this.mtbLancamento.Size = new System.Drawing.Size(100, 20);
            this.mtbLancamento.TabIndex = 3;
            this.mtbLancamento.ValidatingType = typeof(System.DateTime);
            this.mtbLancamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbLancamento_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Lancamento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Geracao:";
            // 
            // grbDadosTecnicos
            // 
            this.grbDadosTecnicos.Controls.Add(this.grbTravaRegiao);
            this.grbDadosTecnicos.Location = new System.Drawing.Point(12, 239);
            this.grbDadosTecnicos.Name = "grbDadosTecnicos";
            this.grbDadosTecnicos.Size = new System.Drawing.Size(468, 156);
            this.grbDadosTecnicos.TabIndex = 2;
            this.grbDadosTecnicos.TabStop = false;
            this.grbDadosTecnicos.Text = "Dados Tecnicos";
            // 
            // grbTravaRegiao
            // 
            this.grbTravaRegiao.Controls.Add(this.ckbLogica);
            this.grbTravaRegiao.Controls.Add(this.ckbFisica);
            this.grbTravaRegiao.Location = new System.Drawing.Point(38, 35);
            this.grbTravaRegiao.Name = "grbTravaRegiao";
            this.grbTravaRegiao.Size = new System.Drawing.Size(200, 100);
            this.grbTravaRegiao.TabIndex = 0;
            this.grbTravaRegiao.TabStop = false;
            this.grbTravaRegiao.Text = "Trava de Regiao";
            // 
            // ckbLogica
            // 
            this.ckbLogica.AutoSize = true;
            this.ckbLogica.Location = new System.Drawing.Point(22, 66);
            this.ckbLogica.Name = "ckbLogica";
            this.ckbLogica.Size = new System.Drawing.Size(58, 17);
            this.ckbLogica.TabIndex = 1;
            this.ckbLogica.Text = "Logica";
            this.ckbLogica.UseVisualStyleBackColor = true;
            // 
            // ckbFisica
            // 
            this.ckbFisica.AutoSize = true;
            this.ckbFisica.Location = new System.Drawing.Point(22, 32);
            this.ckbFisica.Name = "ckbFisica";
            this.ckbFisica.Size = new System.Drawing.Size(53, 17);
            this.ckbFisica.TabIndex = 0;
            this.ckbFisica.Text = "Fisica";
            this.ckbFisica.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(334, 411);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(50, 411);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(50, 411);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Visible = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // frmCadConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 455);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbDadosTecnicos);
            this.Controls.Add(this.grbDadosTempo);
            this.Controls.Add(this.grbDadosPrincipais);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCadConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Console Cadastro";
            this.Load += new System.EventHandler(this.frmCadConsole_Load);
            this.grbDadosPrincipais.ResumeLayout(false);
            this.grbDadosPrincipais.PerformLayout();
            this.grbDadosTempo.ResumeLayout(false);
            this.grbDadosTempo.PerformLayout();
            this.grbDadosTecnicos.ResumeLayout(false);
            this.grbTravaRegiao.ResumeLayout(false);
            this.grbTravaRegiao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDadosPrincipais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbFabricante;
        private System.Windows.Forms.GroupBox grbDadosTempo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbLancamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbDadosTecnicos;
        private System.Windows.Forms.GroupBox grbTravaRegiao;
        private System.Windows.Forms.CheckBox ckbLogica;
        private System.Windows.Forms.CheckBox ckbFisica;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ListBox ltbGeracao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAtualizar;

    }
}