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
    public partial class frmCadJogo : Form
    {
        public frmCadJogo()
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

        private void frmCadJogo_Load(object sender, EventArgs e)
        {
            CarregarListBoxConsoles();
            CarregarListBoxDesenvolvedoras();
            txbCodigo.Enabled = false;
            if (this.Tag != null)
            {
                btnAtualizar.Visible = true;

                Jogo jogo = (Jogo)this.Tag;

                //Carregamento dos Dados do Objeto pessoa para o Form
                CarregarFormDeJogo(jogo);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Jogo j = CarregarJogoDoForm();
                JogoCtrl control = new JogoCtrl();

                //Linha trocada para que o processo seja feito no BD, e não mais no arquivo
                if ((bool)control.BD('i', j))
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

        private Jogo CarregarJogoDoForm()
        {
            Jogo j = new Jogo();

            try
            {
                if (!txbCodigo.Text.Equals(""))
                {
                    j.Codigo = Convert.ToInt64(txbCodigo.Text);
                }
                j.Nome = txbNome.Text;
                j.Franquia = txbFranquia.Text;
                j.Lancamento = mtbLancamento.Text;
                j.Genero = ltbGenero.SelectedIndex;
                j.Midia = cmbMidia.SelectedIndex;
                j.Cnpj = Convert.ToInt64(ltbDev.SelectedValue);
                j.Numero = Convert.ToInt64(ltbConsole.SelectedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }

            return j;
        }

        private void CarregarFormDeJogo(Jogo _j)
        {
            try
            {
                txbCodigo.Text = Convert.ToString(_j.Codigo);
                txbNome.Text = _j.Nome;
                txbFranquia.Text = _j.Franquia;
                mtbLancamento.Text = _j.Lancamento;
                ltbGenero.SelectedIndex = _j.Genero;
                cmbMidia.SelectedIndex = _j.Midia;
                ltbDev.SelectedValue = _j.Cnpj;
                ltbConsole.SelectedValue = _j.Numero;
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
                Jogo j = CarregarJogoDoForm();

                JogoCtrl controlJogo = new JogoCtrl();

                if ((bool)controlJogo.BD('u', j))
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

        private void CarregarListBoxDesenvolvedoras()
        {
            try
            {
                DesenvolvedoraCtrl controlDesenvolvedora = new DesenvolvedoraCtrl();

                Dictionary<Int64, Desenvolvedora> mapaDesenvolvedoras = (Dictionary<Int64, Desenvolvedora>)controlDesenvolvedora.BD('t', null);

                List<Desenvolvedora> listaDesenvolvedoras = mapaDesenvolvedoras.Values.ToList<Desenvolvedora>();

                ltbDev.DisplayMember = "nome";
                ltbDev.ValueMember = "cnpj";

                ltbDev.DataSource = listaDesenvolvedoras;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR LISTBOX DESENVOLVEDORAS: " + ex.Message);
            }
        }
    }
}
