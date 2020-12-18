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
    public partial class frmListaDesenvolvedora : Form
    {
        private Dictionary<Int64, Desenvolvedora> tabelaDesenvolvedoras;
        public frmListaDesenvolvedora()
        {
            InitializeComponent();
        }

        private void frmListaDesenvolvedora_Load(object sender, EventArgs e)
        {
            CarregarGridDoBD("");
        }

        private void CarregarGridDoBD(String _filtro)
        {
            try
            {
                dgvDados.Rows.Clear();

                DesenvolvedoraCtrl control = new DesenvolvedoraCtrl();

                if (_filtro.Equals(""))
                {
                    tabelaDesenvolvedoras = (Dictionary<Int64, Desenvolvedora>)control.BD('t', null);
                }
                else
                {
                    //String[] _filtros = { _filtro };
                    tabelaDesenvolvedoras = (Dictionary<Int64, Desenvolvedora>)control.BD('f', _filtro);
                }

                foreach (Desenvolvedora item in tabelaDesenvolvedoras.Values)
                {
                    dgvDados.Rows.Add(item.Cnpj, item.Nome);
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
                Int64 cnpj = Convert.ToInt64(dgvDados.SelectedRows[0].Cells[0].Value);

                Desenvolvedora d = tabelaDesenvolvedoras[cnpj];

                frmCadDesenvolvedora form = new frmCadDesenvolvedora();

                form.Tag = d;

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
                Int64 cnpj = Convert.ToInt64(dgvDados.SelectedRows[0].Cells[0].Value);

                DesenvolvedoraCtrl control = new DesenvolvedoraCtrl();

                if ((bool)control.BD('d', cnpj))
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
