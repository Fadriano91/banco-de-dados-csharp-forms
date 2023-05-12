using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarefa_SalvarMySql
{
    public partial class FrmClienteCadastrar : Form
    {
        public FrmClienteCadastrar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int idade = int.Parse(txtIdade.Text);
            
            Cliente cli = new Cliente();
            cli.Nome = txtNome.Text;
            cli.Email = txtEmail.Text;
            cli.Idade = idade;
            MessageBox.Show(Cliente.salvarOuEditar(cli));
            limpar();
        }

        private void limpar()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtIdade.Clear();
            txtNome.Focus();
        }
    }
}
