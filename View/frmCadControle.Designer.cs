namespace View
{
    partial class frmCadControle
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
            this.txbCor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSeq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbFabricante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grbDadosFisicos = new System.Windows.Forms.GroupBox();
            this.grbAnalogico = new System.Windows.Forms.GroupBox();
            this.rdbSemAnalogico = new System.Windows.Forms.RadioButton();
            this.rdbComAnalogico = new System.Windows.Forms.RadioButton();
            this.txbNumeroBotoes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grbFio = new System.Windows.Forms.GroupBox();
            this.rdbSemFio = new System.Windows.Forms.RadioButton();
            this.rdbComFio = new System.Windows.Forms.RadioButton();
            this.grbFabricante = new System.Windows.Forms.GroupBox();
            this.grbProcedencia = new System.Windows.Forms.GroupBox();
            this.rdbParalelo = new System.Windows.Forms.RadioButton();
            this.rdbOficial = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grbRelacionamentos = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ltbConsole = new System.Windows.Forms.ListBox();
            this.grbDadosPrincipais.SuspendLayout();
            this.grbDadosFisicos.SuspendLayout();
            this.grbAnalogico.SuspendLayout();
            this.grbFio.SuspendLayout();
            this.grbFabricante.SuspendLayout();
            this.grbProcedencia.SuspendLayout();
            this.grbRelacionamentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDadosPrincipais
            // 
            this.grbDadosPrincipais.Controls.Add(this.txbCor);
            this.grbDadosPrincipais.Controls.Add(this.label2);
            this.grbDadosPrincipais.Controls.Add(this.txbSeq);
            this.grbDadosPrincipais.Controls.Add(this.label1);
            this.grbDadosPrincipais.Location = new System.Drawing.Point(12, 12);
            this.grbDadosPrincipais.Name = "grbDadosPrincipais";
            this.grbDadosPrincipais.Size = new System.Drawing.Size(462, 106);
            this.grbDadosPrincipais.TabIndex = 0;
            this.grbDadosPrincipais.TabStop = false;
            this.grbDadosPrincipais.Text = "Dados Principais";
            // 
            // txbCor
            // 
            this.txbCor.Location = new System.Drawing.Point(331, 40);
            this.txbCor.Name = "txbCor";
            this.txbCor.Size = new System.Drawing.Size(100, 20);
            this.txbCor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cor:";
            // 
            // txbSeq
            // 
            this.txbSeq.Location = new System.Drawing.Point(123, 37);
            this.txbSeq.Name = "txbSeq";
            this.txbSeq.Size = new System.Drawing.Size(100, 20);
            this.txbSeq.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sequencial:";
            // 
            // txbFabricante
            // 
            this.txbFabricante.Location = new System.Drawing.Point(84, 19);
            this.txbFabricante.Name = "txbFabricante";
            this.txbFabricante.Size = new System.Drawing.Size(100, 20);
            this.txbFabricante.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fabricante:";
            // 
            // grbDadosFisicos
            // 
            this.grbDadosFisicos.Controls.Add(this.grbAnalogico);
            this.grbDadosFisicos.Controls.Add(this.txbNumeroBotoes);
            this.grbDadosFisicos.Controls.Add(this.label4);
            this.grbDadosFisicos.Controls.Add(this.grbFio);
            this.grbDadosFisicos.Location = new System.Drawing.Point(12, 124);
            this.grbDadosFisicos.Name = "grbDadosFisicos";
            this.grbDadosFisicos.Size = new System.Drawing.Size(462, 160);
            this.grbDadosFisicos.TabIndex = 1;
            this.grbDadosFisicos.TabStop = false;
            this.grbDadosFisicos.Text = "Dados Fisicos";
            // 
            // grbAnalogico
            // 
            this.grbAnalogico.Controls.Add(this.rdbSemAnalogico);
            this.grbAnalogico.Controls.Add(this.rdbComAnalogico);
            this.grbAnalogico.Location = new System.Drawing.Point(236, 33);
            this.grbAnalogico.Name = "grbAnalogico";
            this.grbAnalogico.Size = new System.Drawing.Size(175, 84);
            this.grbAnalogico.TabIndex = 5;
            this.grbAnalogico.TabStop = false;
            this.grbAnalogico.Text = "Analogico";
            // 
            // rdbSemAnalogico
            // 
            this.rdbSemAnalogico.AutoSize = true;
            this.rdbSemAnalogico.Location = new System.Drawing.Point(29, 52);
            this.rdbSemAnalogico.Name = "rdbSemAnalogico";
            this.rdbSemAnalogico.Size = new System.Drawing.Size(96, 17);
            this.rdbSemAnalogico.TabIndex = 1;
            this.rdbSemAnalogico.TabStop = true;
            this.rdbSemAnalogico.Text = "Sem Analogico";
            this.rdbSemAnalogico.UseVisualStyleBackColor = true;
            // 
            // rdbComAnalogico
            // 
            this.rdbComAnalogico.AutoSize = true;
            this.rdbComAnalogico.Location = new System.Drawing.Point(29, 20);
            this.rdbComAnalogico.Name = "rdbComAnalogico";
            this.rdbComAnalogico.Size = new System.Drawing.Size(96, 17);
            this.rdbComAnalogico.TabIndex = 0;
            this.rdbComAnalogico.TabStop = true;
            this.rdbComAnalogico.Text = "Com Analogico";
            this.rdbComAnalogico.UseVisualStyleBackColor = true;
            // 
            // txbNumeroBotoes
            // 
            this.txbNumeroBotoes.Location = new System.Drawing.Point(143, 131);
            this.txbNumeroBotoes.Name = "txbNumeroBotoes";
            this.txbNumeroBotoes.Size = new System.Drawing.Size(41, 20);
            this.txbNumeroBotoes.TabIndex = 2;
            this.txbNumeroBotoes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNumeroBotoes_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Numero de botoes:";
            // 
            // grbFio
            // 
            this.grbFio.Controls.Add(this.rdbSemFio);
            this.grbFio.Controls.Add(this.rdbComFio);
            this.grbFio.Location = new System.Drawing.Point(17, 33);
            this.grbFio.Name = "grbFio";
            this.grbFio.Size = new System.Drawing.Size(206, 84);
            this.grbFio.TabIndex = 0;
            this.grbFio.TabStop = false;
            this.grbFio.Text = "Fio";
            // 
            // rdbSemFio
            // 
            this.rdbSemFio.AutoSize = true;
            this.rdbSemFio.Location = new System.Drawing.Point(21, 52);
            this.rdbSemFio.Name = "rdbSemFio";
            this.rdbSemFio.Size = new System.Drawing.Size(63, 17);
            this.rdbSemFio.TabIndex = 3;
            this.rdbSemFio.TabStop = true;
            this.rdbSemFio.Text = "Sem Fio";
            this.rdbSemFio.UseVisualStyleBackColor = true;
            // 
            // rdbComFio
            // 
            this.rdbComFio.AutoSize = true;
            this.rdbComFio.Location = new System.Drawing.Point(21, 20);
            this.rdbComFio.Name = "rdbComFio";
            this.rdbComFio.Size = new System.Drawing.Size(63, 17);
            this.rdbComFio.TabIndex = 2;
            this.rdbComFio.TabStop = true;
            this.rdbComFio.Text = "Com Fio";
            this.rdbComFio.UseVisualStyleBackColor = true;
            // 
            // grbFabricante
            // 
            this.grbFabricante.Controls.Add(this.grbProcedencia);
            this.grbFabricante.Controls.Add(this.txbFabricante);
            this.grbFabricante.Controls.Add(this.label3);
            this.grbFabricante.Location = new System.Drawing.Point(12, 290);
            this.grbFabricante.Name = "grbFabricante";
            this.grbFabricante.Size = new System.Drawing.Size(201, 122);
            this.grbFabricante.TabIndex = 2;
            this.grbFabricante.TabStop = false;
            this.grbFabricante.Text = "Fabricante";
            // 
            // grbProcedencia
            // 
            this.grbProcedencia.Controls.Add(this.rdbParalelo);
            this.grbProcedencia.Controls.Add(this.rdbOficial);
            this.grbProcedencia.Location = new System.Drawing.Point(17, 53);
            this.grbProcedencia.Name = "grbProcedencia";
            this.grbProcedencia.Size = new System.Drawing.Size(161, 63);
            this.grbProcedencia.TabIndex = 0;
            this.grbProcedencia.TabStop = false;
            this.grbProcedencia.Text = "Procedencia";
            // 
            // rdbParalelo
            // 
            this.rdbParalelo.AutoSize = true;
            this.rdbParalelo.Location = new System.Drawing.Point(20, 40);
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
            this.rdbOficial.Location = new System.Drawing.Point(20, 17);
            this.rdbOficial.Name = "rdbOficial";
            this.rdbOficial.Size = new System.Drawing.Size(54, 17);
            this.rdbOficial.TabIndex = 0;
            this.rdbOficial.TabStop = true;
            this.rdbOficial.Text = "Oficial";
            this.rdbOficial.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(314, 420);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(38, 420);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 6;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Visible = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(38, 420);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // grbRelacionamentos
            // 
            this.grbRelacionamentos.Controls.Add(this.label5);
            this.grbRelacionamentos.Controls.Add(this.ltbConsole);
            this.grbRelacionamentos.Location = new System.Drawing.Point(231, 290);
            this.grbRelacionamentos.Name = "grbRelacionamentos";
            this.grbRelacionamentos.Size = new System.Drawing.Size(243, 122);
            this.grbRelacionamentos.TabIndex = 6;
            this.grbRelacionamentos.TabStop = false;
            this.grbRelacionamentos.Text = "Relacionamentos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Console:";
            // 
            // ltbConsole
            // 
            this.ltbConsole.FormattingEnabled = true;
            this.ltbConsole.Location = new System.Drawing.Point(111, 22);
            this.ltbConsole.Name = "ltbConsole";
            this.ltbConsole.Size = new System.Drawing.Size(101, 82);
            this.ltbConsole.TabIndex = 0;
            // 
            // frmCadControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 455);
            this.Controls.Add(this.grbRelacionamentos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbFabricante);
            this.Controls.Add(this.grbDadosFisicos);
            this.Controls.Add(this.grbDadosPrincipais);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCadControle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle Cadastro";
            this.Load += new System.EventHandler(this.frmCadControle_Load);
            this.grbDadosPrincipais.ResumeLayout(false);
            this.grbDadosPrincipais.PerformLayout();
            this.grbDadosFisicos.ResumeLayout(false);
            this.grbDadosFisicos.PerformLayout();
            this.grbAnalogico.ResumeLayout(false);
            this.grbAnalogico.PerformLayout();
            this.grbFio.ResumeLayout(false);
            this.grbFio.PerformLayout();
            this.grbFabricante.ResumeLayout(false);
            this.grbFabricante.PerformLayout();
            this.grbProcedencia.ResumeLayout(false);
            this.grbProcedencia.PerformLayout();
            this.grbRelacionamentos.ResumeLayout(false);
            this.grbRelacionamentos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDadosPrincipais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSeq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbFabricante;
        private System.Windows.Forms.GroupBox grbDadosFisicos;
        private System.Windows.Forms.GroupBox grbFio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNumeroBotoes;
        private System.Windows.Forms.GroupBox grbAnalogico;
        private System.Windows.Forms.RadioButton rdbComAnalogico;
        private System.Windows.Forms.RadioButton rdbSemAnalogico;
        private System.Windows.Forms.RadioButton rdbSemFio;
        private System.Windows.Forms.RadioButton rdbComFio;
        private System.Windows.Forms.GroupBox grbFabricante;
        private System.Windows.Forms.GroupBox grbProcedencia;
        private System.Windows.Forms.RadioButton rdbParalelo;
        private System.Windows.Forms.RadioButton rdbOficial;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox grbRelacionamentos;
        private System.Windows.Forms.ListBox ltbConsole;
        private System.Windows.Forms.Label label5;
    }
}