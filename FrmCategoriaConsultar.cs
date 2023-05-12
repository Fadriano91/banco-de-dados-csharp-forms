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
    public partial class FrmCategoriaConsultar : Form
    {
        public FrmCategoriaConsultar()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            cat.Id = Int32.Parse(txtId.Text);

            if(Categoria.pesquisar(cat))
            {
                txtNome.Text = cat.Nome;
                txtNome.BackColor = Color.Goldenrod;
                txtNome.ForeColor = Color.Black;
                txtNome.ReadOnly = false;

                btnExcluir.Enabled = true;
                btnEditar.Enabled = true;
            }
            else
            {
                txtNome.Text = "Categoria não encontrada!";
                txtNome.BackColor = Color.Salmon;
                txtNome.ForeColor = Color.Black;
                btnExcluir.Enabled = false;
                btnEditar.Enabled = false;
            }
            txtId.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string message = "Deseja realmente excluir a Categoria '" + txtNome.Text + "' ?";
            string caption = "Exclusão de Categoria";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Categoria cat = new Categoria();
                MessageBox.Show(cat.excluir(txtId.Text));
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
            string message = "Deseja realmente editar a Categoria '" + txtNome.Text + "' ?";
            string caption = "Edição de Categoria";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Categoria cat = new Categoria();
                cat.Id = Int32.Parse(txtId.Text);
                cat.Nome = txtNome.Text;
                MessageBox.Show(Categoria.editar(cat));
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
            txtId.Focus();
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
        }

    }
}
