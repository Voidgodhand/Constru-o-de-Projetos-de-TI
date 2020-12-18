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
    public partial class frmCadControle : Form
    {
        public frmCadControle()
        {
            InitializeComponent();
        }   

        private void txbNumeroBotoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
                
        private void frmCadControle_Load(object sender, EventArgs e)
        {
            CarregarListBoxConsoles();
            txbSeq.Enabled = false;
            if (this.Tag != null)
            {
                btnAtualizar.Visible = true;

                Controle controle = (Controle)this.Tag;

                CarregarFormDeControle(controle);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Controle c = CarregarControleDoForm();
                ControleCtrl control = new ControleCtrl();

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

        private Controle CarregarControleDoForm()
        {
            Controle c = new Controle();

            try
            {
                if (!txbSeq.Text.Equals(""))
                {
                    c.Seq = Convert.ToInt64(txbSeq.Text);
                }
                c.Cor = txbCor.Text;
                
                if (rdbComFio.Checked)
                {
                    c.Fio = "com fio";
                }
                else
                {
                    c.Fio = "sem fio";
                }

                if (rdbComAnalogico.Checked)
                {
                    c.Analogico = "com analogico";
                }
                else
                {
                    c.Analogico = "sem analogico";
                }

                String numerobotoes = txbNumeroBotoes.Text;
                c.NumeroBotoes = Convert.ToInt64(numerobotoes);
                c.Fabricante = txbFabricante.Text;
                if (rdbOficial.Checked)
                {
                    c.Procedencia = "oficial";
                }
                else
                {
                    c.Procedencia = "paralelo";
                }
                c.Numero = Convert.ToInt64(ltbConsole.SelectedValue);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }

            return c;
        }

        private void CarregarFormDeControle(Controle _c)
        {
            try
            {
                txbSeq.Text = Convert.ToString(_c.Seq);
                txbCor.Text = _c.Cor;
                
                if (_c.Fio.Equals("com fio"))
                {
                    rdbComFio.Checked = true;
                }
                else
                {
                    rdbSemFio.Checked = true;
                }

                if (_c.Analogico.Equals("com analogico"))
                {
                    rdbComAnalogico.Checked = true;
                }
                else
                {
                    rdbSemAnalogico.Checked = true;
                }

                txbNumeroBotoes.Text = _c.NumeroBotoes.ToString();
                txbFabricante.Text = _c.Fabricante;

                if (_c.Procedencia.Equals("oficial"))
                {
                    rdbOficial.Checked = true;
                }
                else
                {
                    rdbParalelo.Checked = true;
                }
                ltbConsole.SelectedValue = _c.Numero;
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
                Controle c = CarregarControleDoForm();
                ControleCtrl controlControle = new ControleCtrl();

                if ((bool)controlControle.BD('u', c))
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

        private void CarregarListBoxConsoles()
        {
            try
            {
                ConsoleCtrl controlConsole = new ConsoleCtrl();

                Dictionary<Int64, Model.Console> mapaConsoles = (Dictionary<Int64, Model.Console>)controlConsole.BD('t', null);

                List<Model.Console> listaConsoles = mapaConsoles.Values.ToList<Model.Console>();

                ltbConsole.DisplayMember = "nome";
                ltbConsole.ValueMember = "numero";

                ltbConsole.DataSource = listaConsoles;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR LISTBOX CONSOLES: " + ex.Message);
            }
        }
    }
}
