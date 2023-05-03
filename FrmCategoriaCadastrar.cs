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
    public partial class FrmCategoriaCadastrar : Form
    {
        public FrmCategoriaCadastrar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            cat.Nome = txtNome.Text;
            MessageBox.Show(Categoria.salvar(cat));
            limpar();
        }

        private void limpar()
        {
            txtNome.Clear();
            txtNome.Focus();
        }
    }
}
