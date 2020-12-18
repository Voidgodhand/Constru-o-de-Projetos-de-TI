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
    public partial class frmCadAcessorio : Form
    {
        public frmCadAcessorio()
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

        private void frmCadAcessorio_Load(object sender, EventArgs e)
        {
            CarregarListBoxConsoles();
            txbId.Enabled = false;
            if (this.Tag != null)
            {
                btnAtualizar.Visible = true;

                Acessorio acessorio = (Acessorio)this.Tag;

                CarregarFormDeAcessorio(acessorio);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Acessorio a = CarregarAcessorioDoForm();

                AcessorioCtrl control = new AcessorioCtrl();

                //Linha trocada para que o processo seja feito no BD, e não mais no arquivo
                if ((bool)control.BD('i', a))
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

        private Acessorio CarregarAcessorioDoForm()
        {
            Acessorio a = new Acessorio();

            try
            {
                if (!txbId.Text.Equals(""))
                {
                    a.Id = Convert.ToInt64(txbId.Text);
                }
                a.Nome = txbNome.Text;
                a.Cor = txbCor.Text;
                a.Tipo = ltbTipo.SelectedIndex;
                a.Lancamento = mtbLancamento.Text;
                a.Fabricante = txbFabricante.Text;

                if (rdbOficial.Checked)
                {
                    a.Procedencia = "oficial";
                }
                else
                {
                    a.Procedencia = "paralelo";
                }
                a.Numero = Convert.ToInt64(ltbConsole.SelectedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }

            return a;
        }

        private void CarregarFormDeAcessorio(Acessorio _a)
        {
            try
            {
                txbId.Text = Convert.ToString(_a.Id);
                txbNome.Text = _a.Nome;
                txbCor.Text = _a.Cor;
                ltbTipo.SelectedIndex = _a.Tipo;
                mtbLancamento.Text = _a.Lancamento;
                txbFabricante.Text = _a.Fabricante;

                if (_a.Procedencia.Equals("oficial"))
                {
                    rdbOficial.Checked = true;
                }
                else
                {
                    rdbParalelo.Checked = true;
                }
                ltbConsole.SelectedValue = _a.Numero;
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
                Acessorio a = CarregarAcessorioDoForm();

                AcessorioCtrl controlAcessorio = new AcessorioCtrl();

                if ((bool)controlAcessorio.BD('u', a))
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
