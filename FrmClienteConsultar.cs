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
    public partial class FrmClienteConsultar : Form
    {
        public FrmClienteConsultar()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            cli.Id = Int32.Parse(txtId.Text);

            if (Cliente.pesquisar(cli))
            {
                txtNome.Text = cli.Nome;
                txtIdade.Text = cli.Idade.ToString();
                txtEmail.Text = cli.Email;
                txtNome.BackColor = Color.Goldenrod;
                txtNome.ForeColor = Color.Black;
                txtNome.ReadOnly = false;
                txtIdade.BackColor = Color.Goldenrod;
                txtIdade.ForeColor = Color.Black;
                txtIdade.ReadOnly = false;
                txtEmail.BackColor = Color.Goldenrod;
                txtEmail.ForeColor = Color.Black;
                txtEmail.ReadOnly = false;

                btnExcluir.Enabled = true;
                btnEditar.Enabled = true;

            }
            else
            {
                txtNome.Text = "Cliente não encontrado!";
                txtIdade.Text = "-";
                txtEmail.Text = "-";
                txtNome.BackColor = Color.Salmon;
                txtNome.ForeColor = Color.Black;
                txtIdade.BackColor = Color.Salmon;
                txtIdade.ForeColor = Color.Black;
                txtEmail.BackColor = Color.Salmon;
                txtEmail.ForeColor = Color.Black;
                btnExcluir.Enabled = false;
                btnEditar.Enabled = false;
            }
            txtId.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string message = "Deseja realmente excluir o cliente '" + txtNome.Text + "' ?";
            string caption = "Exclusão de Cliente";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Cliente cli = new Cliente();
                MessageBox.Show(cli.excluir(txtId.Text));

                limpar();

            }
            else
            {
                MessageBox.Show("Cancelado");
            }
            limpar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string message = "Deseja realmente editar o(a) cliente '" + txtNome.Text + "' ?";
            string caption = "Edição de Cliente";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Cliente cli = new Cliente();
                cli.Id = Int32.Parse(txtId.Text);
                cli.Nome = txtNome.Text;
                cli.Idade = Int32.Parse(txtIdade.Text);
                cli.Email = txtEmail.Text;
                MessageBox.Show(Cliente.salvarOuEditar(cli));

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
            txtNome.ReadOnly = true;
            txtIdade.Clear();
            txtIdade.BackColor = Color.White;
            txtIdade.ReadOnly = true;
            txtEmail.Clear();
            txtEmail.BackColor = Color.White;
            txtEmail.ReadOnly = true;
            txtId.Focus();
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
        }

    }
}
