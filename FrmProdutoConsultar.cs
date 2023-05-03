using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarefa_SalvarMySql.Class;

namespace Tarefa_SalvarMySql
{
    public partial class FrmProdutoConsultar : Form
    {
        public FrmProdutoConsultar()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Produto prod = new Produto();
            prod.Id = Int32.Parse(txtId.Text);

            if (Produto.pesquisar(prod))
            {
                txtNome.Text = prod.Nome;
                txtQuantidadeEstoque.Text = prod.QuantidadeEstoque.ToString();
                txtNome.BackColor = Color.Goldenrod;
                txtNome.ForeColor = Color.Black;
                txtQuantidadeEstoque.BackColor = Color.Goldenrod;
                txtQuantidadeEstoque.ForeColor = Color.Black;
                btnExcluir.Enabled = true;
            }
            else
            {
                txtNome.Text = "Produto não encontrado!";
                txtQuantidadeEstoque.Text = "-";
                txtNome.BackColor = Color.Salmon;
                txtNome.ForeColor = Color.Black;
                txtQuantidadeEstoque.BackColor = Color.Salmon;
                txtQuantidadeEstoque.ForeColor = Color.Black;
                btnExcluir.Enabled = false;
            }
            txtId.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string message = "Deseja realmente excluir o produto " + txtNome.Text + " ?";
            string caption = "Exclusão de Produto";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Produto prod= new Produto();
                MessageBox.Show(prod.excluir(txtId.Text));

                limpar();

            }
            else
            {
                MessageBox.Show("Cancelado");
            }
            limpar();
        }

        private void limpar()
        {
            txtId.Clear();
            txtNome.Clear();
            txtNome.BackColor = Color.White;
            txtQuantidadeEstoque.Clear();
            txtQuantidadeEstoque.BackColor = Color.White;
            txtId.Focus();
            btnExcluir.Enabled = false;
        }
    }
}
