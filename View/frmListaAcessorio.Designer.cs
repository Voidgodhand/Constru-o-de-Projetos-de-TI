namespace View
{
    partial class frmListaAcessorio
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
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.menuPopupDeletar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.iMenuDeletar = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.menuPopupDeletar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Location = new System.Drawing.Point(83, 15);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(313, 20);
            this.txbPesquisa.TabIndex = 3;
            this.txbPesquisa.TextChanged += new System.EventHandler(this.txbPesquisa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisa:";
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNome});
            this.dgvDados.Location = new System.Drawing.Point(12, 50);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(393, 335);
            this.dgvDados.TabIndex = 4;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 50;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 340;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(330, 391);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // menuPopupDeletar
            // 
            this.menuPopupDeletar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iMenuDeletar});
            this.menuPopupDeletar.Name = "menuPopupDeletar";
            this.menuPopupDeletar.Size = new System.Drawing.Size(163, 26);
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
            // frmListaAcessorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 424);
            this.ContextMenuStrip = this.menuPopupDeletar;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.txbPesquisa);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListaAcessorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acessorios Listagem";
            this.Load += new System.EventHandler(this.frmListaAcessorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.menuPopupDeletar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.ContextMenuStrip menuPopupDeletar;
        private System.Windows.Forms.ToolStripMenuItem iMenuDeletar;
    }
}