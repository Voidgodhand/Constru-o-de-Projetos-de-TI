namespace View
{
    partial class frmCadAcessorio
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
            this.grbDadosPrinciapais = new System.Windows.Forms.GroupBox();
            this.txbCor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbFabricante = new System.Windows.Forms.GroupBox();
            this.grbProcedencia = new System.Windows.Forms.GroupBox();
            this.rdbParalelo = new System.Windows.Forms.RadioButton();
            this.rdbOficial = new System.Windows.Forms.RadioButton();
            this.txbFabricante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grbDadosAdicionais = new System.Windows.Forms.GroupBox();
            this.ltbTipo = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mtbLancamento = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grbRelacionamentos = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ltbConsole = new System.Windows.Forms.ListBox();
            this.grbDadosPrinciapais.SuspendLayout();
            this.grbFabricante.SuspendLayout();
            this.grbProcedencia.SuspendLayout();
            this.grbDadosAdicionais.SuspendLayout();
            this.grbRelacionamentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDadosPrinciapais
            // 
            this.grbDadosPrinciapais.Controls.Add(this.txbCor);
            this.grbDadosPrinciapais.Controls.Add(this.label4);
            this.grbDadosPrinciapais.Controls.Add(this.txbNome);
            this.grbDadosPrinciapais.Controls.Add(this.label2);
            this.grbDadosPrinciapais.Controls.Add(this.txbId);
            this.grbDadosPrinciapais.Controls.Add(this.label1);
            this.grbDadosPrinciapais.Location = new System.Drawing.Point(12, 12);
            this.grbDadosPrinciapais.Name = "grbDadosPrinciapais";
            this.grbDadosPrinciapais.Size = new System.Drawing.Size(462, 112);
            this.grbDadosPrinciapais.TabIndex = 0;
            this.grbDadosPrinciapais.TabStop = false;
            this.grbDadosPrinciapais.Text = "Dados Principais";
            // 
            // txbCor
            // 
            this.txbCor.Location = new System.Drawing.Point(90, 63);
            this.txbCor.Name = "txbCor";
            this.txbCor.Size = new System.Drawing.Size(100, 20);
            this.txbCor.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cor:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(311, 20);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(90, 20);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(100, 20);
            this.txbId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // grbFabricante
            // 
            this.grbFabricante.Controls.Add(this.grbProcedencia);
            this.grbFabricante.Controls.Add(this.txbFabricante);
            this.grbFabricante.Controls.Add(this.label3);
            this.grbFabricante.Location = new System.Drawing.Point(12, 274);
            this.grbFabricante.Name = "grbFabricante";
            this.grbFabricante.Size = new System.Drawing.Size(190, 124);
            this.grbFabricante.TabIndex = 3;
            this.grbFabricante.TabStop = false;
            this.grbFabricante.Text = "Fabricante";
            // 
            // grbProcedencia
            // 
            this.grbProcedencia.Controls.Add(this.rdbParalelo);
            this.grbProcedencia.Controls.Add(this.rdbOficial);
            this.grbProcedencia.Location = new System.Drawing.Point(6, 53);
            this.grbProcedencia.Name = "grbProcedencia";
            this.grbProcedencia.Size = new System.Drawing.Size(174, 65);
            this.grbProcedencia.TabIndex = 0;
            this.grbProcedencia.TabStop = false;
            this.grbProcedencia.Text = "Procedencia";
            // 
            // rdbParalelo
            // 
            this.rdbParalelo.AutoSize = true;
            this.rdbParalelo.Location = new System.Drawing.Point(26, 42);
            this.rdbParalelo.Name = "rdbParalelo";
            this.rdbParalelo.Size = new System.Drawing.Size(63, 17);
            this.rdbParalelo.TabIndex = 1;
            this.rdbParalelo.TabStop = true;
            this.rdbParalelo.Text = "Paralelo";
            this.rdbParalelo.UseVisualStyleBackColor = true;
            // 
            // rdbOficial
            // 
            this.rdbOficial.AutoSize = true;
            this.rdbOficial.Location = new System.Drawing.Point(26, 19);
            this.rdbOficial.Name = "rdbOficial";
            this.rdbOficial.Size = new System.Drawing.Size(54, 17);
            this.rdbOficial.TabIndex = 0;
            this.rdbOficial.TabStop = true;
            this.rdbOficial.Text = "Oficial";
            this.rdbOficial.UseVisualStyleBackColor = true;
            // 
            // txbFabricante
            // 
            this.txbFabricante.Location = new System.Drawing.Point(80, 19);
            this.txbFabricante.Name = "txbFabricante";
            this.txbFabricante.Size = new System.Drawing.Size(100, 20);
            this.txbFabricante.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fabricante:";
            // 
            // grbDadosAdicionais
            // 
            this.grbDadosAdicionais.Controls.Add(this.ltbTipo);
            this.grbDadosAdicionais.Controls.Add(this.label7);
            this.grbDadosAdicionais.Controls.Add(this.mtbLancamento);
            this.grbDadosAdicionais.Controls.Add(this.label5);
            this.grbDadosAdicionais.Location = new System.Drawing.Point(12, 130);
            this.grbDadosAdicionais.Name = "grbDadosAdicionais";
            this.grbDadosAdicionais.Size = new System.Drawing.Size(462, 138);
            this.grbDadosAdicionais.TabIndex = 4;
            this.grbDadosAdicionais.TabStop = false;
            this.grbDadosAdicionais.Text = "Dados Adicionais";
            // 
            // ltbTipo
            // 
            this.ltbTipo.FormattingEnabled = true;
            this.ltbTipo.Items.AddRange(new object[] {
            "Memory Card",
            "Controle Alternativo",
            "Light Gun",
            "Add-on",
            "Sensor de Movimento",
            "Óculos de Realidade Virtual",
            "Óculos 3d",
            "Tapete de Danca",
            "Mesa Digitalizadora",
            "Mouse",
            "Teclado",
            "Brinquedo",
            "Câmera",
            "Microfone",
            "Impressora",
            "Cabo",
            "Pedaço de Plastico",
            "Dispositivo de Hack"});
            this.ltbTipo.Location = new System.Drawing.Point(68, 35);
            this.ltbTipo.Name = "ltbTipo";
            this.ltbTipo.Size = new System.Drawing.Size(153, 95);
            this.ltbTipo.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tipo:";
            // 
            // mtbLancamento
            // 
            this.mtbLancamento.Location = new System.Drawing.Point(315, 73);
            this.mtbLancamento.Mask = "00/00/0000";
            this.mtbLancamento.Name = "mtbLancamento";
            this.mtbLancamento.Size = new System.Drawing.Size(100, 20);
            this.mtbLancamento.TabIndex = 5;
            this.mtbLancamento.ValidatingType = typeof(System.DateTime);
            this.mtbLancamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbLancamento_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lancamento:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(367, 420);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(37, 420);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Visible = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(37, 420);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // grbRelacionamentos
            // 
            this.grbRelacionamentos.Controls.Add(this.label6);
            this.grbRelacionamentos.Controls.Add(this.ltbConsole);
            this.grbRelacionamentos.Location = new System.Drawing.Point(219, 274);
            this.grbRelacionamentos.Name = "grbRelacionamentos";
            this.grbRelacionamentos.Size = new System.Drawing.Size(243, 124);
            this.grbRelacionamentos.TabIndex = 7;
            this.grbRelacionamentos.TabStop = false;
            this.grbRelacionamentos.Text = "Relacionamentos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Console:";
            // 
            // ltbConsole
            // 
            this.ltbConsole.FormattingEnabled = true;
            this.ltbConsole.Location = new System.Drawing.Point(108, 22);
            this.ltbConsole.Name = "ltbConsole";
            this.ltbConsole.Size = new System.Drawing.Size(101, 82);
            this.ltbConsole.TabIndex = 0;
            // 
            // frmCadAcessorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 455);
            this.Controls.Add(this.grbRelacionamentos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbDadosAdicionais);
            this.Controls.Add(this.grbFabricante);
            this.Controls.Add(this.grbDadosPrinciapais);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCadAcessorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acessorio Cadastro";
            this.Load += new System.EventHandler(this.frmCadAcessorio_Load);
            this.grbDadosPrinciapais.ResumeLayout(false);
            this.grbDadosPrinciapais.PerformLayout();
            this.grbFabricante.ResumeLayout(false);
            this.grbFabricante.PerformLayout();
            this.grbProcedencia.ResumeLayout(false);
            this.grbProcedencia.PerformLayout();
            this.grbDadosAdicionais.ResumeLayout(false);
            this.grbDadosAdicionais.PerformLayout();
            this.grbRelacionamentos.ResumeLayout(false);
            this.grbRelacionamentos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDadosPrinciapais;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbFabricante;
        private System.Windows.Forms.GroupBox grbProcedencia;
        private System.Windows.Forms.RadioButton rdbParalelo;
        private System.Windows.Forms.RadioButton rdbOficial;
        private System.Windows.Forms.TextBox txbFabricante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbDadosAdicionais;
        private System.Windows.Forms.ListBox ltbTipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtbLancamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox grbRelacionamentos;
        private System.Windows.Forms.ListBox ltbConsole;
        private System.Windows.Forms.Label label6;
    }
}