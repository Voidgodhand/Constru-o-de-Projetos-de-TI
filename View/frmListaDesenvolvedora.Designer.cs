namespace View
{
    partial class frmListaDesenvolvedora
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
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.colCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuPopupDeletar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.iMenuDeletar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.Button();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.menuPopupDeletar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCnpj,
            this.colNome});
            this.dgvDados.ContextMenuStrip = this.menuPopupDeletar;
            this.dgvDados.Location = new System.Drawing.Point(12, 45);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(393, 335);
            this.dgvDados.TabIndex = 1;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // colCnpj
            // 
            this.colCnpj.HeaderText = "CNPJ";
            this.colCnpj.Name = "colCnpj";
            this.colCnpj.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 290;
            // 
            // menuPopupDeletar
            // 
            this.menuPopupDeletar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iMenuDeletar});
            this.menuPopupDeletar.Name = "menuPopupDeletar";
            this.menuPopupDeletar.Size = new System.Drawing.Size(163, 48);
            this.menuPopupDeletar.Text = "Operações";
            // 
            // iMenuDeletar
            // 
            this.iMenuDeletar.Name = "iMenuDeletar";
            this.iMenuDeletar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.iMenuDeletar.Size = new System.Drawing.Size(162, 22);
            this.iMenuDeletar.Text = "&Deletar";
            this.iMenuDeletar.Click += new System.EventHandler(this.iMenuDeletar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(312, 389);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Location = new System.Drawing.Point(84, 15);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(313, 20);
            this.txbPesquisa.TabIndex = 5;
            this.txbPesquisa.TextChanged += new System.EventHandler(this.txbPesquisa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pesquisa:";
            // 
            // frmListaDesenvolvedora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 424);
            this.Controls.Add(this.txbPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgvDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListaDesenvolvedora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desenvolvedora Listagem";
            this.Load += new System.EventHandler(this.frmListaDesenvolvedora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.menuPopupDeletar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip menuPopupDeletar;
        private System.Windows.Forms.ToolStripMenuItem iMenuDeletar;
    }
}