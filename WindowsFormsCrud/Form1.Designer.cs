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
            this.textoNome = new System.Windows.Forms.Label();
            this.textoEmail = new System.Windows.Forms.Label();
            this.textoTelefone = new System.Windows.Forms.Label();
            this.campoNome = new System.Windows.Forms.TextBox();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.campoTelefone = new System.Windows.Forms.TextBox();
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoNome
            // 
            this.textoNome.AutoSize = true;
            this.textoNome.Location = new System.Drawing.Point(39, 38);
            this.textoNome.Name = "textoNome";
            this.textoNome.Size = new System.Drawing.Size(44, 16);
            this.textoNome.TabIndex = 0;
            this.textoNome.Text = "Nome";
            this.textoNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // textoEmail
            // 
            this.textoEmail.AutoSize = true;
            this.textoEmail.Location = new System.Drawing.Point(39, 113);
            this.textoEmail.Name = "textoEmail";
            this.textoEmail.Size = new System.Drawing.Size(41, 16);
            this.textoEmail.TabIndex = 1;
            this.textoEmail.Text = "Email";
            // 
            // textoTelefone
            // 
            this.textoTelefone.AutoSize = true;
            this.textoTelefone.Location = new System.Drawing.Point(36, 199);
            this.textoTelefone.Name = "textoTelefone";
            this.textoTelefone.Size = new System.Drawing.Size(61, 16);
            this.textoTelefone.TabIndex = 2;
            this.textoTelefone.Text = "Telefone";
            // 
            // campoNome
            // 
            this.campoNome.Location = new System.Drawing.Point(39, 67);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(334, 22);
            this.campoNome.TabIndex = 3;
            // 
            // campoEmail
            // 
            this.campoEmail.Location = new System.Drawing.Point(39, 146);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(334, 22);
            this.campoEmail.TabIndex = 4;
            // 
            // campoTelefone
            // 
            this.campoTelefone.Location = new System.Drawing.Point(39, 240);
            this.campoTelefone.Name = "campoTelefone";
            this.campoTelefone.Size = new System.Drawing.Size(334, 22);
            this.campoTelefone.TabIndex = 5;
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Location = new System.Drawing.Point(258, 305);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(115, 29);
            this.botaoSalvar.TabIndex = 6;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 357);
            this.Controls.Add(this.botaoSalvar);
            this.Controls.Add(this.campoTelefone);
            this.Controls.Add(this.campoEmail);
            this.Controls.Add(this.campoNome);
            this.Controls.Add(this.textoTelefone);
            this.Controls.Add(this.textoEmail);
            this.Controls.Add(this.textoNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoNome;
        private System.Windows.Forms.Label textoEmail;
        private System.Windows.Forms.Label textoTelefone;
        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.TextBox campoTelefone;
        private System.Windows.Forms.Button botaoSalvar;
    }
}

