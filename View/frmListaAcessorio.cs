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
    public partial class frmListaAcessorio : Form
    {
        private Dictionary<Int64, Acessorio> tabelaAcessorios;
        public frmListaAcessorio()
        {
            InitializeComponent();
        }

        private void frmListaAcessorio_Load(object sender, EventArgs e)
        {
            CarregarGridDoBD("");
        }

        private void CarregarGridDoBD(String _filtro)
        {
            try
            {
                dgvDados.Rows.Clear();

                AcessorioCtrl control = new AcessorioCtrl();

                if (_filtro.Equals(""))
                {
                    tabelaAcessorios = (Dictionary<Int64, Acessorio>)control.BD('t', null);
                }
                else
                {
                    //String[] _filtros = { _filtro };
                    tabelaAcessorios = (Dictionary<Int64, Acessorio>)control.BD('f', _filtro);
                }

                foreach (Acessorio item in tabelaAcessorios.Values)
                {
                    dgvDados.Rows.Add(item.Id, item.Nome);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR BD: " + ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Int64 id = Convert.ToInt64(dgvDados.SelectedRows[0].Cells[0].Value);

                Acessorio a = tabelaAcessorios[id];

                frmCadAcessorio form = new frmCadAcessorio();

                form.Tag = a;

                form.ShowDialog();

                CarregarGridDoBD("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO SELECIONAR CADASTRO: " + ex.Message);
            }
        }

        private void iMenuDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                Int64 id = Convert.ToInt64(dgvDados.SelectedRows[0].Cells[0].Value);

                AcessorioCtrl control = new AcessorioCtrl();

                if ((bool)control.BD('d', id))
                {
                    MessageBox.Show("Cadastro deletado com sucesso!!");
                }

                CarregarGridDoBD("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO DELETAR CADASTRO: " + ex.Message);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void txbPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CarregarGridDoBD(txbPesquisa.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO PESQUISAR: " + ex.Message);
            }
        }
    }
}
