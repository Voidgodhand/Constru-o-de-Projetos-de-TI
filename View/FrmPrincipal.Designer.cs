namespace View
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.itemMenuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.barraTarefa = new System.Windows.Forms.ToolStrip();
            this.itemBarraConsoleListagem = new System.Windows.Forms.ToolStripButton();
            this.itemBarraConsoleCadastro = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemBarraControleListagem = new System.Windows.Forms.ToolStripButton();
            this.itemBarraControleCadastro = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.itemBarraJogoListagem = new System.Windows.Forms.ToolStripButton();
            this.itemBarraJogoCadastro = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.itemBarraAcessorioListagem = new System.Windows.Forms.ToolStripButton();
            this.itemBarraAcessorioCadastro = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.itemBarraDevListagem = new System.Windows.Forms.ToolStripButton();
            this.itemBarraDevCadastro = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUserLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuPrincipal.SuspendLayout();
            this.barraTarefa.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMenuArquivo});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(669, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // itemMenuArquivo
            // 
            this.itemMenuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMenuSair});
            this.itemMenuArquivo.Name = "itemMenuArquivo";
            this.itemMenuArquivo.Size = new System.Drawing.Size(61, 20);
            this.itemMenuArquivo.Text = "&Arquivo";
            // 
            // itemMenuSair
            // 
            this.itemMenuSair.Name = "itemMenuSair";
            this.itemMenuSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.itemMenuSair.Size = new System.Drawing.Size(134, 22);
            this.itemMenuSair.Text = "Sair";
            this.itemMenuSair.Click += new System.EventHandler(this.itemMenuSair_Click);
            // 
            // barraTarefa
            // 
            this.barraTarefa.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.barraTarefa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemBarraConsoleListagem,
            this.itemBarraConsoleCadastro,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.itemBarraControleListagem,
            this.itemBarraControleCadastro,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.itemBarraJogoListagem,
            this.itemBarraJogoCadastro,
            this.toolStripLabel3,
            this.toolStripSeparator3,
            this.itemBarraAcessorioListagem,
            this.itemBarraAcessorioCadastro,
            this.toolStripLabel4,
            this.toolStripSeparator4,
            this.itemBarraDevListagem,
            this.itemBarraDevCadastro,
            this.toolStripLabel5});
            this.barraTarefa.Location = new System.Drawing.Point(0, 24);
            this.barraTarefa.Name = "barraTarefa";
            this.barraTarefa.Size = new System.Drawing.Size(669, 32);
            this.barraTarefa.TabIndex = 1;
            this.barraTarefa.Text = "toolStrip1";
            // 
            // itemBarraConsoleListagem
            // 
            this.itemBarraConsoleListagem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itemBarraConsoleListagem.Image = ((System.Drawing.Image)(resources.GetObject("itemBarraConsoleListagem.Image")));
            this.itemBarraConsoleListagem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itemBarraConsoleListagem.Name = "itemBarraConsoleListagem";
            this.itemBarraConsoleListagem.Size = new System.Drawing.Size(29, 29);
            this.itemBarraConsoleListagem.Text = "Listagem de Consoles";
            this.itemBarraConsoleListagem.Click += new System.EventHandler(this.itemBarraConsoleListagem_Click);
            // 
            // itemBarraConsoleCadastro
            // 
            this.itemBarraConsoleCadastro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itemBarraConsoleCadastro.Image = ((System.Drawing.Image)(resources.GetObject("itemBarraConsoleCadastro.Image")));
            this.itemBarraConsoleCadastro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itemBarraConsoleCadastro.Name = "itemBarraConsoleCadastro";
            this.itemBarraConsoleCadastro.Size = new System.Drawing.Size(29, 29);
            this.itemBarraConsoleCadastro.Text = "Cadastrar Console";
            this.itemBarraConsoleCadastro.Click += new System.EventHandler(this.itemBarraConsoleCadastro_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 29);
            this.toolStripLabel1.Text = "Console";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // itemBarraControleListagem
            // 
            this.itemBarraControleListagem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itemBarraControleListagem.Image = global::View.Properties.Resources.edit_list;
            this.itemBarraControleListagem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itemBarraControleListagem.Name = "itemBarraControleListagem";
            this.itemBarraControleListagem.Size = new System.Drawing.Size(29, 29);
            this.itemBarraControleListagem.Text = "Listagem de Controles";
            this.itemBarraControleListagem.Click += new System.EventHandler(this.itemBarraControleListagem_Click);
            // 
            // itemBarraControleCadastro
            // 
            this.itemBarraControleCadastro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itemBarraControleCadastro.Image = global::View.Properties.Resources.Plus_icon;
            this.itemBarraControleCadastro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itemBarraControleCadastro.Name = "itemBarraControleCadastro";
            this.itemBarraControleCadastro.Size = new System.Drawing.Size(29, 29);
            this.itemBarraControleCadastro.Text = "Cadastrar Controle";
            this.itemBarraControleCadastro.Click += new System.EventHandler(this.itemBarraControleCadastro_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(53, 29);
            this.toolStripLabel2.Text = "Controle";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // itemBarraJogoListagem
            // 
            this.itemBarraJogoListagem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itemBarraJogoListagem.Image = global::View.Properties.Resources.edit_list;
            this.itemBarraJogoListagem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itemBarraJogoListagem.Name = "itemBarraJogoListagem";
            this.itemBarraJogoListagem.Size = new System.Drawing.Size(29, 29);
            this.itemBarraJogoListagem.Text = "Listagem de Jogos";
            this.itemBarraJogoListagem.Click += new System.EventHandler(this.itemBarraJogoListagem_Click);
            // 
            // itemBarraJogoCadastro
            // 
            this.itemBarraJogoCadastro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itemBarraJogoCadastro.Image = global::View.Properties.Resources.Plus_icon;
            this.itemBarraJogoCadastro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itemBarraJogoCadastro.Name = "itemBarraJogoCadastro";
            this.itemBarraJogoCadastro.Size = new System.Drawing.Size(29, 29);
            this.itemBarraJogoCadastro.Text = "Cadastrar Jogo";
            this.itemBarraJogoCadastro.Click += new System.EventHandler(this.itemBarraJogoCadastro_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(32, 29);
            this.toolStripLabel3.Text = "Jogo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 32);
            // 
            // itemBarraAcessorioListagem
            // 
            this.itemBarraAcessorioListagem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itemBarraAcessorioListagem.Image = global::View.Properties.Resources.edit_list;
            this.itemBarraAcessorioListagem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itemBarraAcessorioListagem.Name = "itemBarraAcessorioListagem";
            this.itemBarraAcessorioListagem.Size = new System.Drawing.Size(29, 29);
            this.itemBarraAcessorioListagem.Text = "Listagem de Acessorios";
            this.itemBarraAcessorioListagem.Click += new System.EventHandler(this.itemBarraAcessorioListagem_Click);
            // 
            // itemBarraAcessorioCadastro
            // 
            this.itemBarraAcessorioCadastro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itemBarraAcessorioCadastro.Image = global::View.Properties.Resources.Plus_icon;
            this.itemBarraAcessorioCadastro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itemBarraAcessorioCadastro.Name = "itemBarraAcessorioCadastro";
            this.itemBarraAcessorioCadastro.Size = new System.Drawing.Size(29, 29);
            this.itemBarraAcessorioCadastro.Text = "Cadastrar Acessorio";
            this.itemBarraAcessorioCadastro.Click += new System.EventHandler(this.itemBarraAcessorioCadastro_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(58, 29);
            this.toolStripLabel4.Text = "Acessorio";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 32);
            // 
            // itemBarraDevListagem
            // 
            this.itemBarraDevListagem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itemBarraDevListagem.Image = global::View.Properties.Resources.edit_list;
            this.itemBarraDevListagem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itemBarraDevListagem.Name = "itemBarraDevListagem";
            this.itemBarraDevListagem.Size = new System.Drawing.Size(29, 29);
            this.itemBarraDevListagem.Text = "Listagem de Desenvolvedoras";
            this.itemBarraDevListagem.Click += new System.EventHandler(this.itemBarraDevListagem_Click);
            // 
            // itemBarraDevCadastro
            // 
            this.itemBarraDevCadastro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itemBarraDevCadastro.Image = global::View.Properties.Resources.Plus_icon;
            this.itemBarraDevCadastro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itemBarraDevCadastro.Name = "itemBarraDevCadastro";
            this.itemBarraDevCadastro.Size = new System.Drawing.Size(29, 29);
            this.itemBarraDevCadastro.Text = "Cadastrar Desenvolvedora";
            this.itemBarraDevCadastro.Click += new System.EventHandler(this.itemBarraDevCadastro_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(91, 29);
            this.toolStripLabel5.Text = "Desenvolvedora";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUserLogado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 379);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(669, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUserLogado
            // 
            this.lblUserLogado.Name = "lblUserLogado";
            this.lblUserLogado.Size = new System.Drawing.Size(16, 17);
            this.lblUserLogado.Text = "...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::View.Properties.Resources.video_game;
            this.pictureBox1.Location = new System.Drawing.Point(0, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(669, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 401);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.barraTarefa);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrmPrincipal";
            this.Text = "Videogames";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.barraTarefa.ResumeLayout(false);
            this.barraTarefa.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem itemMenuArquivo;
        private System.Windows.Forms.ToolStripMenuItem itemMenuSair;
        private System.Windows.Forms.ToolStrip barraTarefa;
        private System.Windows.Forms.ToolStripButton itemBarraConsoleListagem;
        private System.Windows.Forms.ToolStripButton itemBarraConsoleCadastro;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton itemBarraControleListagem;
        private System.Windows.Forms.ToolStripButton itemBarraControleCadastro;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton itemBarraJogoListagem;
        private System.Windows.Forms.ToolStripButton itemBarraJogoCadastro;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton itemBarraAcessorioListagem;
        private System.Windows.Forms.ToolStripButton itemBarraAcessorioCadastro;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton itemBarraDevListagem;
        private System.Windows.Forms.ToolStripButton itemBarraDevCadastro;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripStatusLabel lblUserLogado;
    }
}