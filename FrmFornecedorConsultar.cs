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
    public partial class FrmFornecedorConsultar : Form
    {
        public FrmFornecedorConsultar()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Fornecedor forn = new Fornecedor();
            forn.Id = Int32.Parse(txtId.Text);

            if (Fornecedor.pesquisar(forn))
            {
                txtRazaoSocial.Text = forn.RazaoSocial;
                txtCnpj.Text = forn.Cnpj.ToString();
                txtEmail.Text = forn.Email;
                txtRazaoSocial.BackColor = Color.Goldenrod;
                txtRazaoSocial.ForeColor = Color.Black;
                txtCnpj.BackColor = Color.Goldenrod;
                txtCnpj.ForeColor = Color.Black;
                txtEmail.BackColor = Color.Goldenrod;
                txtEmail.ForeColor = Color.Black;
                btnExcluir.Enabled = true;
            }
            else
            {
                txtRazaoSocial.Text = "Fornecedor não encontrado!";
                txtCnpj.Text = "-";
                txtEmail.Text = "-";
                txtRazaoSocial.BackColor = Color.Salmon;
                txtRazaoSocial.ForeColor = Color.Black;
                txtCnpj.BackColor = Color.Salmon;
                txtCnpj.ForeColor = Color.Black;
                txtEmail.BackColor = Color.Salmon;
                txtEmail.ForeColor = Color.Black;
                btnExcluir.Enabled = false;
            }
            txtId.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string message = "Deseja realmente excluir o fornecedor " + txtRazaoSocial.Text + " ?";
            string caption = "Exclusão de Fornecedor";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Fornecedor forn= new Fornecedor();
                MessageBox.Show(forn.excluir(txtId.Text));

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
            txtRazaoSocial.Clear();
            txtRazaoSocial.BackColor = Color.White;
            txtCnpj.Clear();
            txtCnpj.BackColor = Color.White;
            txtEmail.Clear();
            txtEmail.BackColor = Color.White;
            txtId.Focus();
            btnExcluir.Enabled = false;
        }
    }
}
