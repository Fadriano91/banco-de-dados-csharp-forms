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
                txtIdade.BackColor = Color.Goldenrod;
                txtIdade.ForeColor = Color.Black;
                txtEmail.BackColor = Color.Goldenrod;
                txtEmail.ForeColor = Color.Black;
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
            }
            txtId.Focus();
        }
    }
}
