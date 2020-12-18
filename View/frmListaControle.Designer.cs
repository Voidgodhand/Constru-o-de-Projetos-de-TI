namespace View
{
    partial class frmListaControle
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
            this.colSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuPopupDeletar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.iMenuDeletar = new System.Windows.Forms.ToolStripMenuItem();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
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
            this.colSeq,
            this.colCor});
            this.dgvDados.ContextMenuStrip = this.menuPopupDeletar;
            this.dgvDados.Location = new System.Drawing.Point(12, 54);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(393, 323);
            this.dgvDados.TabIndex = 0;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // colSeq
            // 
            this.colSeq.HeaderText = "Sequencial";
            this.colSeq.Name = "colSeq";
            this.colSeq.ReadOnly = true;
            this.colSeq.Width = 70;
            // 
            // colCor
            // 
            this.colCor.HeaderText = "Cor";
            this.colCor.Name = "colCor";
            this.colCor.ReadOnly = true;
            this.colCor.Width = 320;
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
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(330, 389);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmListaControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 424);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txbPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListaControle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controles Listagem";
            this.Load += new System.EventHandler(this.frmListaControle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.menuPopupDeletar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeq;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCor;
        private System.Windows.Forms.ContextMenuStrip menuPopupDeletar;
        private System.Windows.Forms.ToolStripMenuItem iMenuDeletar;
    }
}