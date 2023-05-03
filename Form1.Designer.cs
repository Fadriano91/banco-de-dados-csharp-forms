namespace Tarefa_SalvarMySql
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.itemClienteCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemClienteListar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemClienteConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCategoriaCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCategoriaListar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCategoriaConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFornecedorCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFornecedorListar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.itemProdutoCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemProdutoListar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemProdutoConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFornecedorConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCliente,
            this.menuCategoria,
            this.menuFornecedor,
            this.menuProduto});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuCliente
            // 
            this.menuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemClienteCadastrar,
            this.itemClienteListar,
            this.itemClienteConsultar});
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(56, 20);
            this.menuCliente.Text = "Cliente";
            // 
            // itemClienteCadastrar
            // 
            this.itemClienteCadastrar.Name = "itemClienteCadastrar";
            this.itemClienteCadastrar.Size = new System.Drawing.Size(125, 22);
            this.itemClienteCadastrar.Text = "Cadastrar";
            this.itemClienteCadastrar.Click += new System.EventHandler(this.itemClienteCadastrar_Click);
            // 
            // itemClienteListar
            // 
            this.itemClienteListar.Name = "itemClienteListar";
            this.itemClienteListar.Size = new System.Drawing.Size(125, 22);
            this.itemClienteListar.Text = "Listar";
            this.itemClienteListar.Click += new System.EventHandler(this.itemClienteListar_Click);
            // 
            // itemClienteConsultar
            // 
            this.itemClienteConsultar.Name = "itemClienteConsultar";
            this.itemClienteConsultar.Size = new System.Drawing.Size(125, 22);
            this.itemClienteConsultar.Text = "Consultar";
            this.itemClienteConsultar.Click += new System.EventHandler(this.itemClienteConsultar_Click);
            // 
            // menuCategoria
            // 
            this.menuCategoria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCategoriaCadastrar,
            this.itemCategoriaListar,
            this.itemCategoriaConsultar});
            this.menuCategoria.Name = "menuCategoria";
            this.menuCategoria.Size = new System.Drawing.Size(70, 20);
            this.menuCategoria.Text = "Categoria";
            // 
            // itemCategoriaCadastrar
            // 
            this.itemCategoriaCadastrar.Name = "itemCategoriaCadastrar";
            this.itemCategoriaCadastrar.Size = new System.Drawing.Size(125, 22);
            this.itemCategoriaCadastrar.Text = "Cadastrar";
            this.itemCategoriaCadastrar.Click += new System.EventHandler(this.itemCategoriaCadastrar_Click);
            // 
            // itemCategoriaListar
            // 
            this.itemCategoriaListar.Name = "itemCategoriaListar";
            this.itemCategoriaListar.Size = new System.Drawing.Size(125, 22);
            this.itemCategoriaListar.Text = "Listar";
            this.itemCategoriaListar.Click += new System.EventHandler(this.itemCategoriaListar_Click);
            // 
            // itemCategoriaConsultar
            // 
            this.itemCategoriaConsultar.Name = "itemCategoriaConsultar";
            this.itemCategoriaConsultar.Size = new System.Drawing.Size(125, 22);
            this.itemCategoriaConsultar.Text = "Consultar";
            this.itemCategoriaConsultar.Click += new System.EventHandler(this.itemCategoriaConsultar_Click);
            // 
            // menuFornecedor
            // 
            this.menuFornecedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemFornecedorCadastrar,
            this.itemFornecedorListar,
            this.itemFornecedorConsultar});
            this.menuFornecedor.Name = "menuFornecedor";
            this.menuFornecedor.Size = new System.Drawing.Size(79, 20);
            this.menuFornecedor.Text = "Fornecedor";
            // 
            // itemFornecedorCadastrar
            // 
            this.itemFornecedorCadastrar.Name = "itemFornecedorCadastrar";
            this.itemFornecedorCadastrar.Size = new System.Drawing.Size(180, 22);
            this.itemFornecedorCadastrar.Text = "Cadastrar";
            this.itemFornecedorCadastrar.Click += new System.EventHandler(this.itemFornecedorCadastrar_Click);
            // 
            // itemFornecedorListar
            // 
            this.itemFornecedorListar.Name = "itemFornecedorListar";
            this.itemFornecedorListar.Size = new System.Drawing.Size(180, 22);
            this.itemFornecedorListar.Text = "Listar";
            this.itemFornecedorListar.Click += new System.EventHandler(this.itemFornecedorListar_Click);
            // 
            // menuProduto
            // 
            this.menuProduto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemProdutoCadastrar,
            this.itemProdutoListar,
            this.itemProdutoConsultar});
            this.menuProduto.Name = "menuProduto";
            this.menuProduto.Size = new System.Drawing.Size(62, 20);
            this.menuProduto.Text = "Produto";
            // 
            // itemProdutoCadastrar
            // 
            this.itemProdutoCadastrar.Name = "itemProdutoCadastrar";
            this.itemProdutoCadastrar.Size = new System.Drawing.Size(125, 22);
            this.itemProdutoCadastrar.Text = "Cadastrar";
            this.itemProdutoCadastrar.Click += new System.EventHandler(this.itemProdutoCadastrar_Click);
            // 
            // itemProdutoListar
            // 
            this.itemProdutoListar.Name = "itemProdutoListar";
            this.itemProdutoListar.Size = new System.Drawing.Size(125, 22);
            this.itemProdutoListar.Text = "Listar";
            this.itemProdutoListar.Click += new System.EventHandler(this.itemProdutoListar_Click);
            // 
            // itemProdutoConsultar
            // 
            this.itemProdutoConsultar.Name = "itemProdutoConsultar";
            this.itemProdutoConsultar.Size = new System.Drawing.Size(125, 22);
            this.itemProdutoConsultar.Text = "Consultar";
            this.itemProdutoConsultar.Click += new System.EventHandler(this.itemProdutoConsultar_Click);
            // 
            // itemFornecedorConsultar
            // 
            this.itemFornecedorConsultar.Name = "itemFornecedorConsultar";
            this.itemFornecedorConsultar.Size = new System.Drawing.Size(180, 22);
            this.itemFornecedorConsultar.Text = "Consultar";
            this.itemFornecedorConsultar.Click += new System.EventHandler(this.itemFornecedorConsultar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuCliente;
        private System.Windows.Forms.ToolStripMenuItem itemClienteCadastrar;
        private System.Windows.Forms.ToolStripMenuItem itemClienteListar;
        private System.Windows.Forms.ToolStripMenuItem menuCategoria;
        private System.Windows.Forms.ToolStripMenuItem itemCategoriaCadastrar;
        private System.Windows.Forms.ToolStripMenuItem itemCategoriaListar;
        private System.Windows.Forms.ToolStripMenuItem menuFornecedor;
        private System.Windows.Forms.ToolStripMenuItem itemFornecedorCadastrar;
        private System.Windows.Forms.ToolStripMenuItem itemFornecedorListar;
        private System.Windows.Forms.ToolStripMenuItem menuProduto;
        private System.Windows.Forms.ToolStripMenuItem itemProdutoCadastrar;
        private System.Windows.Forms.ToolStripMenuItem itemProdutoListar;
        private System.Windows.Forms.ToolStripMenuItem itemCategoriaConsultar;
        private System.Windows.Forms.ToolStripMenuItem itemProdutoConsultar;
        private System.Windows.Forms.ToolStripMenuItem itemClienteConsultar;
        private System.Windows.Forms.ToolStripMenuItem itemFornecedorConsultar;
    }
}

