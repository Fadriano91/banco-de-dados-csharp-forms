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
    public partial class FrmProdutoCadastrar : Form
    {
        public FrmProdutoCadastrar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int quantidadeEstoque = int.Parse(txtQuantidadeEstoque.Text);
            
            Produto prod = new Produto();
            prod.Nome = txtNome.Text;
            prod.QuantidadeEstoque = quantidadeEstoque;
            MessageBox.Show(Produto.salvar(prod));
            limpar();
        }

        private void limpar()
        {
            txtNome.Clear();
            txtQuantidadeEstoque.Clear();
            txtNome.Focus();
        }
    }
}
