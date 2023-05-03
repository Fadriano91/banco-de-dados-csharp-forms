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
    public partial class FrmFornecedorCadastrar : Form
    {
        public FrmFornecedorCadastrar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            float cnpj = float.Parse(txtCnpj.Text);

            Fornecedor forn = new Fornecedor();
            forn.RazaoSocial = txtRazaoSocial.Text;
            forn.Email = txtEmail.Text;
            forn.Cnpj = cnpj;
            MessageBox.Show(Fornecedor.salvar(forn));
            limpar();
        }

        private void limpar()
        {
            txtRazaoSocial.Clear();
            txtEmail.Clear();
            txtCnpj.Clear();
            txtRazaoSocial.Focus();
        }
    }
}
