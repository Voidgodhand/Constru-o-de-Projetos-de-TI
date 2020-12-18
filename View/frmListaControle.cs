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
    public partial class frmListaControle : Form
    {
        private Dictionary<Int64, Controle> tabelaControles;
        public frmListaControle()
        {
            InitializeComponent();
        }

        private void frmListaControle_Load(object sender, EventArgs e)
        {
            CarregarGridDoBD("");
        }

        private void CarregarGridDoBD(String _filtro)
        {
            try
            {
                dgvDados.Rows.Clear();

                ControleCtrl control = new ControleCtrl();

                if (_filtro.Equals(""))
                {
                    tabelaControles = (Dictionary<Int64, Controle>)control.BD('t', null);
                }
                else
                {
                    //String[] _filtros = { _filtro };
                    tabelaControles = (Dictionary<Int64, Controle>)control.BD('f', _filtro);
                }

                foreach (Controle item in tabelaControles.Values)
                {
                    dgvDados.Rows.Add(item.Seq, item.Cor);
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
                Int64 seq = Convert.ToInt64(dgvDados.SelectedRows[0].Cells[0].Value);

                Controle c = tabelaControles[seq];

                frmCadControle form = new frmCadControle();

                form.Tag = c;

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
                Int64 seq = Convert.ToInt64(dgvDados.SelectedRows[0].Cells[0].Value);

                ControleCtrl control = new ControleCtrl();

                if ((bool)control.BD('d', seq))
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
