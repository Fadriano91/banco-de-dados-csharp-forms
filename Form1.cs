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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        // menuCliente

        private void itemClienteCadastrar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmClienteCadastrar>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmClienteCadastrar>().First().Focus();
            }
            else
            {
                FrmClienteCadastrar frm = new FrmClienteCadastrar();
                frm.Show();
            }
        }

        private void itemClienteListar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Cliente.listar());
        }

        private void itemClienteConsultar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmClienteConsultar>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmClienteConsultar>().First().Focus();
            }
            else
            {
                FrmClienteConsultar frm = new FrmClienteConsultar();
                frm.Show();
            }
        }

        // menuCategoria

        private void itemCategoriaCadastrar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCategoriaCadastrar>().Count() > 0) 
            {
                Application.OpenForms.OfType<FrmCategoriaCadastrar>().First().Focus();
            }
            else
            {
                FrmCategoriaCadastrar frm = new FrmCategoriaCadastrar();
                frm.Show();
            }
        }

        private void itemCategoriaListar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Categoria.listar());
        }
        private void itemCategoriaConsultar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCategoriaConsultar>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmCategoriaConsultar>().First().Focus();
            }
            else
            {
                FrmCategoriaConsultar frm = new FrmCategoriaConsultar();
                frm.Show();
            }
        }

        // menuFornecedor

        private void itemFornecedorCadastrar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmFornecedorCadastrar>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmFornecedorCadastrar>().First().Focus();
            }
            else
            {
                FrmFornecedorCadastrar frm = new FrmFornecedorCadastrar();
                frm.Show();
            }
        }

        private void itemFornecedorListar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Fornecedor.listar());
        }

        // menuProduto

        private void itemProdutoCadastrar_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<FrmProdutoCadastrar>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmProdutoCadastrar>().First().Focus();
            }
            else
            {
                FrmProdutoCadastrar frm = new FrmProdutoCadastrar();
                frm.Show();
            }
        }

        private void itemProdutoListar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Produto.listar());
        }

        private void itemProdutoConsultar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmProdutoConsultar>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmProdutoConsultar>().First().Focus();
            }
            else
            {
                FrmProdutoConsultar frm = new FrmProdutoConsultar();
                frm.Show();
            }
        }

        
    }
}
