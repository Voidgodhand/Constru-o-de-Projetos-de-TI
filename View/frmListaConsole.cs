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
    public partial class frmListaConsole : Form
    {
        private Dictionary<Int64, Model.Console> tabelaConsoles;
        public frmListaConsole()
        {
            InitializeComponent();
        }

        private void frmListaConsole_Load(object sender, EventArgs e)
        {
            CarregarGridDoBD("");
        }

        private void CarregarGridDoBD(String _filtro)
        {
            try
            {
                dgvDados.Rows.Clear();

                ConsoleCtrl control = new ConsoleCtrl();

                if (_filtro.Equals(""))
                {
                    tabelaConsoles = (Dictionary<Int64, Model.Console>)control.BD('t', null);
                }
                else
                {
                    //String[] _filtros = { _filtro };
                    tabelaConsoles = (Dictionary<Int64, Model.Console>)control.BD('f', _filtro);
                }

                foreach (Model.Console item in tabelaConsoles.Values)
                {
                    dgvDados.Rows.Add(item.Numero, item.Nome);
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
                Int64 numero = Convert.ToInt64(dgvDados.SelectedRows[0].Cells[0].Value);

                Model.Console c = tabelaConsoles[numero];

                frmCadConsole form = new frmCadConsole();

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
                Int64 numero = Convert.ToInt64(dgvDados.SelectedRows[0].Cells[0].Value);

                ConsoleCtrl control = new ConsoleCtrl();

                if ((bool)control.BD('d', numero))
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
