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
    public partial class frmListaJogo : Form
    {
        private Dictionary<Int64, Jogo> tabelaJogos;
        public frmListaJogo()
        {
            InitializeComponent();
        }

        private void frmListaJogo_Load(object sender, EventArgs e)
        {
            CarregarGridDoBD("");
        }

        private void CarregarGridDoBD(String _filtro)
        {
            try
            {
                dgvDados.Rows.Clear();

                JogoCtrl control = new JogoCtrl();

                if (_filtro.Equals(""))
                {
                    tabelaJogos = (Dictionary<Int64, Jogo>)control.BD('t', null);
                }
                else
                {
                    //String[] _filtros = { _filtro };
                    tabelaJogos = (Dictionary<Int64, Jogo>)control.BD('f', _filtro);
                }

                foreach (Jogo item in tabelaJogos.Values)
                {
                    dgvDados.Rows.Add(item.Codigo, item.Nome);
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
                Int64 codigo = Convert.ToInt64(dgvDados.SelectedRows[0].Cells[0].Value);

                Jogo j = tabelaJogos[codigo];

                frmCadJogo form = new frmCadJogo();

                form.Tag = j;

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
                Int64 codigo = Convert.ToInt64(dgvDados.SelectedRows[0].Cells[0].Value);

                JogoCtrl control = new JogoCtrl();

                if ((bool)control.BD('d', codigo))
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
