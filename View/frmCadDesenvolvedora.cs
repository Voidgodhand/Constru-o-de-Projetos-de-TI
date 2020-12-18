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
    public partial class frmCadDesenvolvedora : Form
    {
        public frmCadDesenvolvedora()
        {
            InitializeComponent();
        }

        private void mtbFundacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txbNumeroEmpregados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void frmCadDesenvolvedora_Load(object sender, EventArgs e)
        {
            txbCnpj.Enabled = false;
            if (this.Tag != null)
            {
                btnAtualizar.Visible = true;

                Desenvolvedora desenvolvedora = (Desenvolvedora)this.Tag;

                //Carregamento dos Dados do Objeto pessoa para o Form
                CarregarFormDeDesenvolvedora(desenvolvedora);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Desenvolvedora d = CarregarDesenvolvedoraDoForm();

                DesenvolvedoraCtrl control = new DesenvolvedoraCtrl();

                //Linha trocada para que o processo seja feito no BD, e não mais no arquivo
                if ((bool)control.BD('i', d))
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

        private Desenvolvedora CarregarDesenvolvedoraDoForm()
        {
            Desenvolvedora d = new Desenvolvedora();

            try
            {
                if (!txbCnpj.Text.Equals(""))
                {
                    d.Cnpj = Convert.ToInt64(txbCnpj.Text);
                }
                d.Nome = txbNome.Text;
                d.Presidente = txbPresidente.Text;
                d.Fundador = txbFundador.Text;
                d.Fundacao = mtbFundacao.Text;
                String numeroempregados = txbNumeroEmpregados.Text;
                d.NumeroEmpregados = Convert.ToInt64(numeroempregados);

                if (rdbIndependente.Checked)
                {
                    d.Tipo = "independente";
                }
                else if (rdbSubsidiaria.Checked)
                {
                    d.Tipo = "subsidiaria";
                }

                else if (rdbDefunta.Checked)
                {
                    d.Tipo = "defunta";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }

            return d;
        }

        private void CarregarFormDeDesenvolvedora(Desenvolvedora _d)
        {
            try
            {
                txbCnpj.Text = Convert.ToString(_d.Cnpj);
                txbNome.Text = _d.Nome;
                txbPresidente.Text = _d.Presidente;
                txbFundador.Text = _d.Fundador;
                mtbFundacao.Text = _d.Fundacao;
                txbNumeroEmpregados.Text = _d.NumeroEmpregados.ToString();

                if (_d.Tipo.Equals("independente"))
                {
                    rdbIndependente.Checked = true;
                }
                else if (_d.Tipo.Equals("subsidiaria"))
                {
                    rdbSubsidiaria.Checked = true;
                }

                else if (_d.Tipo.Equals("defunta"))
                {
                    rdbDefunta.Checked = true;
                }
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
                Desenvolvedora d = CarregarDesenvolvedoraDoForm();

                DesenvolvedoraCtrl controlDesenvolvedora = new DesenvolvedoraCtrl();

                if ((bool)controlDesenvolvedora.BD('u', d))
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
