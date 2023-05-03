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
            }
            else
            {
                txtNome.Text = "Categoria não encontrada!";
                txtNome.BackColor = Color.Salmon;
                txtNome.ForeColor = Color.Black;
            }
            txtId.Focus();
        }
    }
}
