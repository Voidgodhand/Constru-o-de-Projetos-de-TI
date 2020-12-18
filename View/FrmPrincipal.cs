using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Hide();

            frmLogin form = new frmLogin();

            if (form.ShowDialog() == DialogResult.OK)
            {
                Usuario user = (Usuario)form.Tag;

                lblUserLogado.Text = user.Nome;

                this.Show();
            }
            else
            {
                this.Close();
            }
        }
        private void MostrarAlgoNaTela(String _texto)
        {
            MessageBox.Show(_texto);
        }

        private void itemMenuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemBarraConsoleListagem_Click(object sender, EventArgs e)
        {
            frmListaConsole form = new frmListaConsole();

            form.ShowDialog();
        }

        private void itemBarraConsoleCadastro_Click(object sender, EventArgs e)
        {
            frmCadConsole form = new frmCadConsole();

            form.ShowDialog();
        }

        private void itemBarraControleListagem_Click(object sender, EventArgs e)
        {
            frmListaControle form = new frmListaControle();

            form.ShowDialog();
        }

        private void itemBarraControleCadastro_Click(object sender, EventArgs e)
        {
            frmCadControle form = new frmCadControle();

            form.ShowDialog();
        }

        private void itemBarraJogoListagem_Click(object sender, EventArgs e)
        {
            frmListaJogo form = new frmListaJogo();

            form.ShowDialog();
        }

        private void itemBarraJogoCadastro_Click(object sender, EventArgs e)
        {
            frmCadJogo form = new frmCadJogo();

            form.ShowDialog();
        }

        private void itemBarraAcessorioListagem_Click(object sender, EventArgs e)
        {
            frmListaAcessorio form = new frmListaAcessorio();

            form.ShowDialog();
        }

        private void itemBarraAcessorioCadastro_Click(object sender, EventArgs e)
        {
            frmCadAcessorio form = new frmCadAcessorio();

            form.ShowDialog();
        }

        private void itemBarraDevListagem_Click(object sender, EventArgs e)
        {
            frmListaDesenvolvedora form = new frmListaDesenvolvedora();

            form.ShowDialog();
        }

        private void itemBarraDevCadastro_Click(object sender, EventArgs e)
        {
            frmCadDesenvolvedora form = new frmCadDesenvolvedora();

            form.ShowDialog();
        }


    }
}
