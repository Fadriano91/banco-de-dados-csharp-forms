using MySql.Data.MySqlClient;
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
            //carregar comboBox com dados de carregar() da class Categoria
            MySqlDataReader res = Categoria.carregar();

            if (res.HasRows)
            {
                while (res.Read())
                {
                    cmbCategoria.Items.Add(
                        res["id"].ToString() + " - " +
                        res["nome"].ToString()
                        );
                }
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int quantidadeEstoque = int.Parse(txtQuantidadeEstoque.Text);
            string[] categoriaCarregar = cmbCategoria.SelectedItem.ToString().Split();


            Produto prod = new Produto();
            prod.Nome = txtNome.Text;
            prod.QuantidadeEstoque = quantidadeEstoque;
            prod.Id_categoria = Int32.Parse(categoriaCarregar[0].Trim());
            MessageBox.Show(Produto.salvar(prod));
            limpar();
        }

        private void limpar()
        {
            txtNome.Clear();
            txtQuantidadeEstoque.Clear();
            cmbCategoria.SelectedIndex = -1;
            txtNome.Focus();
        }
    }
}
