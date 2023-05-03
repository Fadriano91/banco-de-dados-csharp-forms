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
            }
            else
            {
                txtNome.Text = "Produto não encontrado!";
                txtQuantidadeEstoque.Text = "-";
                txtNome.BackColor = Color.Salmon;
                txtNome.ForeColor = Color.Black;
                txtQuantidadeEstoque.BackColor = Color.Salmon;
                txtQuantidadeEstoque.ForeColor = Color.Black;
            }
            txtId.Focus();
        }
    }
}
