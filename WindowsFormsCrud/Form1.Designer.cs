namespace WindowsFormsCrud
{
    partial class Sistema
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
            this.components = new System.ComponentModel.Container();
            this.textoNomeProd = new System.Windows.Forms.Label();
            this.textoQuantidade = new System.Windows.Forms.Label();
            this.textoPreco = new System.Windows.Forms.Label();
            this.campoNomeProd = new System.Windows.Forms.TextBox();
            this.campoQuantidade = new System.Windows.Forms.TextBox();
            this.campoPreco = new System.Windows.Forms.TextBox();
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.campoListagem = new System.Windows.Forms.ListView();
            this.textoPesquisa = new System.Windows.Forms.Label();
            this.botaoPesquisa = new System.Windows.Forms.Button();
            this.campoPesquisa = new System.Windows.Forms.TextBox();
            this.Adicionar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.excluirProduto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.excluirPrdut = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoNomeProd
            // 
            this.textoNomeProd.AutoSize = true;
            this.textoNomeProd.Location = new System.Drawing.Point(39, 38);
            this.textoNomeProd.Name = "textoNomeProd";
            this.textoNomeProd.Size = new System.Drawing.Size(94, 16);
            this.textoNomeProd.TabIndex = 0;
            this.textoNomeProd.Text = "Nome Produto";
            this.textoNomeProd.UseWaitCursor = true;
            // 
            // textoQuantidade
            // 
            this.textoQuantidade.AutoSize = true;
            this.textoQuantidade.Location = new System.Drawing.Point(39, 113);
            this.textoQuantidade.Name = "textoQuantidade";
            this.textoQuantidade.Size = new System.Drawing.Size(77, 16);
            this.textoQuantidade.TabIndex = 1;
            this.textoQuantidade.Text = "Quantidade";
            // 
            // textoPreco
            // 
            this.textoPreco.AutoSize = true;
            this.textoPreco.Location = new System.Drawing.Point(39, 199);
            this.textoPreco.Name = "textoPreco";
            this.textoPreco.Size = new System.Drawing.Size(43, 16);
            this.textoPreco.TabIndex = 2;
            this.textoPreco.Text = "Preço";
            // 
            // campoNomeProd
            // 
            this.campoNomeProd.Location = new System.Drawing.Point(39, 67);
            this.campoNomeProd.Name = "campoNomeProd";
            this.campoNomeProd.Size = new System.Drawing.Size(334, 22);
            this.campoNomeProd.TabIndex = 3;
            // 
            // campoQuantidade
            // 
            this.campoQuantidade.Location = new System.Drawing.Point(39, 146);
            this.campoQuantidade.Name = "campoQuantidade";
            this.campoQuantidade.Size = new System.Drawing.Size(334, 22);
            this.campoQuantidade.TabIndex = 4;
            // 
            // campoPreco
            // 
            this.campoPreco.Location = new System.Drawing.Point(39, 240);
            this.campoPreco.Name = "campoPreco";
            this.campoPreco.Size = new System.Drawing.Size(334, 22);
            this.campoPreco.TabIndex = 5;
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Location = new System.Drawing.Point(164, 305);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(94, 29);
            this.botaoSalvar.TabIndex = 6;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.UseVisualStyleBackColor = true;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // campoListagem
            // 
            this.campoListagem.HideSelection = false;
            this.campoListagem.Location = new System.Drawing.Point(421, 67);
            this.campoListagem.Name = "campoListagem";
            this.campoListagem.Size = new System.Drawing.Size(685, 267);
            this.campoListagem.TabIndex = 7;
            this.campoListagem.UseCompatibleStateImageBehavior = false;
            this.campoListagem.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.campoListagem.ContextMenuStripChanged += new System.EventHandler(this.botaoExcluir_Click);
            // 
            // textoPesquisa
            // 
            this.textoPesquisa.AutoSize = true;
            this.textoPesquisa.Location = new System.Drawing.Point(418, 38);
            this.textoPesquisa.Name = "textoPesquisa";
            this.textoPesquisa.Size = new System.Drawing.Size(64, 16);
            this.textoPesquisa.TabIndex = 8;
            this.textoPesquisa.Text = "Pesquisa";
            // 
            // botaoPesquisa
            // 
            this.botaoPesquisa.Location = new System.Drawing.Point(1011, 38);
            this.botaoPesquisa.Name = "botaoPesquisa";
            this.botaoPesquisa.Size = new System.Drawing.Size(95, 23);
            this.botaoPesquisa.TabIndex = 9;
            this.botaoPesquisa.Text = "Buscar";
            this.botaoPesquisa.UseVisualStyleBackColor = true;
            this.botaoPesquisa.Click += new System.EventHandler(this.botaoPesquisa_Click_1);
            // 
            // campoPesquisa
            // 
            this.campoPesquisa.Location = new System.Drawing.Point(488, 38);
            this.campoPesquisa.Name = "campoPesquisa";
            this.campoPesquisa.Size = new System.Drawing.Size(502, 22);
            this.campoPesquisa.TabIndex = 10;
            // 
            // Adicionar
            // 
            this.Adicionar.Location = new System.Drawing.Point(39, 305);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(94, 29);
            this.Adicionar.TabIndex = 11;
            this.Adicionar.Text = "Limpar";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.botaoLimpar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.botaoExcluir_Click);
            // 
            // excluirProduto
            // 
            this.excluirProduto.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.excluirProduto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excluirPrdut});
            this.excluirProduto.Name = "excluirProduto";
            this.excluirProduto.Size = new System.Drawing.Size(122, 28);
            // 
            // excluirPrdut
            // 
            this.excluirPrdut.Name = "excluirPrdut";
            this.excluirPrdut.Size = new System.Drawing.Size(121, 24);
            this.excluirPrdut.Text = "Excluir";
            this.excluirPrdut.Click += new System.EventHandler(this.excluirPrdut_Click);
            // 
            // Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 357);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.campoPesquisa);
            this.Controls.Add(this.botaoPesquisa);
            this.Controls.Add(this.textoPesquisa);
            this.Controls.Add(this.campoListagem);
            this.Controls.Add(this.botaoSalvar);
            this.Controls.Add(this.campoPreco);
            this.Controls.Add(this.campoQuantidade);
            this.Controls.Add(this.campoNomeProd);
            this.Controls.Add(this.textoPreco);
            this.Controls.Add(this.textoQuantidade);
            this.Controls.Add(this.textoNomeProd);
            this.Name = "Sistema";
            this.Text = "Sistema Cadastro";
            this.excluirProduto.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoNomeProd;
        private System.Windows.Forms.Label textoQuantidade;
        private System.Windows.Forms.Label textoPreco;
        private System.Windows.Forms.TextBox campoNomeProd;
        private System.Windows.Forms.TextBox campoQuantidade;
        private System.Windows.Forms.TextBox campoPreco;
        private System.Windows.Forms.Button botaoSalvar;
        private System.Windows.Forms.ListView campoListagem;
        private System.Windows.Forms.Label textoPesquisa;
        private System.Windows.Forms.Button botaoPesquisa;
        private System.Windows.Forms.TextBox campoPesquisa;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip excluirProduto;
        private System.Windows.Forms.ToolStripMenuItem excluirPrdut;
    }
}

