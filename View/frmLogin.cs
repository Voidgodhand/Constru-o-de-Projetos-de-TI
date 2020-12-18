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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario user = new Usuario();

                user.Nome = txbUsuario.Text;
                user.Senha = txbSenha.Text;

                if (ValidarLogin(user))
                {
                    this.DialogResult = DialogResult.OK;

                    this.Tag = user;

                    this.Close();
                }
                else
                {
                    lblMsg.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        private bool ValidarLogin(Usuario _user)
        {
            bool resultado;
            try
            {
                if (_user.Nome.Equals("joao") && _user.Senha.Equals("joao"))
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }

                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
                return false;
            }
        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }


    }
}
