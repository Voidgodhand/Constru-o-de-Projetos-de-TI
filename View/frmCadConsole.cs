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
using Control;

namespace View
{
    public partial class frmCadConsole : Form
    {
        public frmCadConsole()
        {
            InitializeComponent();
        }
                
        private void mtbLancamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void frmCadConsole_Load(object sender, EventArgs e)
        {
            txbNumero.Enabled = false;
            if (this.Tag != null)
            {
                btnAtualizar.Visible = true;

                Model.Console console = (Model.Console)this.Tag;

                CarregarFormDeConsole(console);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
               Model.Console c  = CarregarConsoleDoForm();

               ConsoleCtrl control = new ConsoleCtrl();

               //Linha trocada para que o processo seja feito no BD, e não mais no arquivo
               if ((bool)control.BD('i', c))
               {
                   MessageBox.Show("Cadastro efetuado com sucesso!!!");
                   this.Close();
               }
               else
               {
                   MessageBox.Show("Cadastro não efetuado!!!");
               }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        private Model.Console CarregarConsoleDoForm()
        {
            Model.Console c = new Model.Console();

            try
            {
                if (!txbNumero.Text.Equals(""))
                {
                    c.Numero = Convert.ToInt64(txbNumero.Text);
                }
                c.Nome = txbNome.Text;
                c.Fabricante = txbFabricante.Text;
                c.Tipo = cmbTipo.SelectedIndex;
                c.Lancamento = mtbLancamento.Text;
                c.Geracao = ltbGeracao.SelectedIndex;
                c.TravaFisica = ckbFisica.Checked;
                c.TravaLogica = ckbLogica.Checked;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }

            return c;
        }

        private void CarregarFormDeConsole(Model.Console _c)
        {
            try
            {
                txbNumero.Text = Convert.ToString(_c.Numero);
                txbNome.Text = _c.Nome;
                txbFabricante.Text = _c.Fabricante;
                cmbTipo.SelectedIndex = _c.Tipo;
                mtbLancamento.Text = _c.Lancamento;
                ltbGeracao.SelectedIndex = _c.Geracao;
                ckbFisica.Checked = _c.TravaFisica;
                ckbLogica.Checked = _c.TravaLogica;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR FORMULARIO: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Console c = CarregarConsoleDoForm();

                ConsoleCtrl controlConsole = new ConsoleCtrl();

                if ((bool)controlConsole.BD('u', c))
                {
                    MessageBox.Show("Cadastro atualizado com sucesso!!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO ATUALIZAR DADOS: " + ex.Message);
            }
        }            
    }

}
