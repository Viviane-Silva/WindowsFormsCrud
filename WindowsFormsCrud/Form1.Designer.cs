namespace WindowsFormsCrud
{
    partial class Form1
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
            this.textoNomeProd = new System.Windows.Forms.Label();
            this.textoQuantidade = new System.Windows.Forms.Label();
            this.textoPreco = new System.Windows.Forms.Label();
            this.campoNomeProd = new System.Windows.Forms.TextBox();
            this.campoQuantidade = new System.Windows.Forms.TextBox();
            this.campoPreco = new System.Windows.Forms.TextBox();
            this.botaoSalvar = new System.Windows.Forms.Button();
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
            this.textoNomeProd.Click += new System.EventHandler(this.label1_Click);
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
            this.textoPreco.Location = new System.Drawing.Point(36, 199);
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
            this.botaoSalvar.Location = new System.Drawing.Point(258, 305);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(115, 29);
            this.botaoSalvar.TabIndex = 6;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.UseVisualStyleBackColor = true;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 357);
            this.Controls.Add(this.botaoSalvar);
            this.Controls.Add(this.campoPreco);
            this.Controls.Add(this.campoQuantidade);
            this.Controls.Add(this.campoNomeProd);
            this.Controls.Add(this.textoPreco);
            this.Controls.Add(this.textoQuantidade);
            this.Controls.Add(this.textoNomeProd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

