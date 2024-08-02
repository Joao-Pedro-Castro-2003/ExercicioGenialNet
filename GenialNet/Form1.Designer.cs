namespace GenialNet
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
            this.NomeProduto = new System.Windows.Forms.Label();
            this.textNomeProduto = new System.Windows.Forms.TextBox();
            this.MarcaProduto = new System.Windows.Forms.Label();
            this.MedidaProduto = new System.Windows.Forms.Label();
            this.textMarcaProduto = new System.Windows.Forms.TextBox();
            this.textMedidaProduto = new System.Windows.Forms.TextBox();
            this.TituloProduto = new System.Windows.Forms.Label();
            this.TituloFornecedor = new System.Windows.Forms.Label();
            this.NomeFornecedor = new System.Windows.Forms.Label();
            this.CnpjFornecedor = new System.Windows.Forms.Label();
            this.EnderecoFornecedor = new System.Windows.Forms.Label();
            this.TelefoneFornecedor = new System.Windows.Forms.Label();
            this.ProdutosFornecedor = new System.Windows.Forms.Label();
            this.textNomeFornecedor = new System.Windows.Forms.TextBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.textProdutos = new System.Windows.Forms.TextBox();
            this.Gravar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.Erro_Msg = new System.Windows.Forms.Label();
            this.textCnpjMask = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // NomeProduto
            // 
            this.NomeProduto.AutoSize = true;
            this.NomeProduto.Location = new System.Drawing.Point(12, 80);
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.Size = new System.Drawing.Size(92, 13);
            this.NomeProduto.TabIndex = 1;
            this.NomeProduto.Text = "Nome do produto:";
            // 
            // textNomeProduto
            // 
            this.textNomeProduto.Location = new System.Drawing.Point(119, 73);
            this.textNomeProduto.Name = "textNomeProduto";
            this.textNomeProduto.Size = new System.Drawing.Size(110, 20);
            this.textNomeProduto.TabIndex = 2;
            this.textNomeProduto.TextChanged += new System.EventHandler(this.textNomeProduto_TextChanged);
            // 
            // MarcaProduto
            // 
            this.MarcaProduto.AutoSize = true;
            this.MarcaProduto.Location = new System.Drawing.Point(12, 106);
            this.MarcaProduto.Name = "MarcaProduto";
            this.MarcaProduto.Size = new System.Drawing.Size(40, 13);
            this.MarcaProduto.TabIndex = 3;
            this.MarcaProduto.Text = "Marca:";
            // 
            // MedidaProduto
            // 
            this.MedidaProduto.AutoSize = true;
            this.MedidaProduto.Location = new System.Drawing.Point(12, 132);
            this.MedidaProduto.Name = "MedidaProduto";
            this.MedidaProduto.Size = new System.Drawing.Size(45, 13);
            this.MedidaProduto.TabIndex = 4;
            this.MedidaProduto.Text = "Medida:";
            // 
            // textMarcaProduto
            // 
            this.textMarcaProduto.Location = new System.Drawing.Point(119, 99);
            this.textMarcaProduto.Name = "textMarcaProduto";
            this.textMarcaProduto.Size = new System.Drawing.Size(110, 20);
            this.textMarcaProduto.TabIndex = 5;
            this.textMarcaProduto.TextChanged += new System.EventHandler(this.textMarcaProduto_TextChanged);
            // 
            // textMedidaProduto
            // 
            this.textMedidaProduto.Location = new System.Drawing.Point(119, 125);
            this.textMedidaProduto.Name = "textMedidaProduto";
            this.textMedidaProduto.Size = new System.Drawing.Size(110, 20);
            this.textMedidaProduto.TabIndex = 6;
            this.textMedidaProduto.TextChanged += new System.EventHandler(this.textMedidaProduto_TextChanged);
            // 
            // TituloProduto
            // 
            this.TituloProduto.AutoSize = true;
            this.TituloProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloProduto.Location = new System.Drawing.Point(67, 15);
            this.TituloProduto.Name = "TituloProduto";
            this.TituloProduto.Size = new System.Drawing.Size(109, 31);
            this.TituloProduto.TabIndex = 7;
            this.TituloProduto.Text = "Produto";
            // 
            // TituloFornecedor
            // 
            this.TituloFornecedor.AutoSize = true;
            this.TituloFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloFornecedor.Location = new System.Drawing.Point(380, 15);
            this.TituloFornecedor.Name = "TituloFornecedor";
            this.TituloFornecedor.Size = new System.Drawing.Size(153, 31);
            this.TituloFornecedor.TabIndex = 8;
            this.TituloFornecedor.Text = "Fornecedor";
            // 
            // NomeFornecedor
            // 
            this.NomeFornecedor.AutoSize = true;
            this.NomeFornecedor.Location = new System.Drawing.Point(302, 72);
            this.NomeFornecedor.Name = "NomeFornecedor";
            this.NomeFornecedor.Size = new System.Drawing.Size(110, 13);
            this.NomeFornecedor.TabIndex = 9;
            this.NomeFornecedor.Text = "Nome do Fornecedor:";
            // 
            // CnpjFornecedor
            // 
            this.CnpjFornecedor.AutoSize = true;
            this.CnpjFornecedor.Location = new System.Drawing.Point(302, 96);
            this.CnpjFornecedor.Name = "CnpjFornecedor";
            this.CnpjFornecedor.Size = new System.Drawing.Size(37, 13);
            this.CnpjFornecedor.TabIndex = 10;
            this.CnpjFornecedor.Text = "CNPJ:";
            // 
            // EnderecoFornecedor
            // 
            this.EnderecoFornecedor.AutoSize = true;
            this.EnderecoFornecedor.Location = new System.Drawing.Point(302, 123);
            this.EnderecoFornecedor.Name = "EnderecoFornecedor";
            this.EnderecoFornecedor.Size = new System.Drawing.Size(56, 13);
            this.EnderecoFornecedor.TabIndex = 11;
            this.EnderecoFornecedor.Text = "Endereço:";
            // 
            // TelefoneFornecedor
            // 
            this.TelefoneFornecedor.AutoSize = true;
            this.TelefoneFornecedor.Location = new System.Drawing.Point(302, 150);
            this.TelefoneFornecedor.Name = "TelefoneFornecedor";
            this.TelefoneFornecedor.Size = new System.Drawing.Size(52, 13);
            this.TelefoneFornecedor.TabIndex = 12;
            this.TelefoneFornecedor.Text = "Telefone:";
            // 
            // ProdutosFornecedor
            // 
            this.ProdutosFornecedor.AutoSize = true;
            this.ProdutosFornecedor.Location = new System.Drawing.Point(302, 177);
            this.ProdutosFornecedor.Name = "ProdutosFornecedor";
            this.ProdutosFornecedor.Size = new System.Drawing.Size(52, 13);
            this.ProdutosFornecedor.TabIndex = 13;
            this.ProdutosFornecedor.Text = "Produtos:";
            // 
            // textNomeFornecedor
            // 
            this.textNomeFornecedor.Location = new System.Drawing.Point(422, 69);
            this.textNomeFornecedor.Name = "textNomeFornecedor";
            this.textNomeFornecedor.Size = new System.Drawing.Size(152, 20);
            this.textNomeFornecedor.TabIndex = 14;
            this.textNomeFornecedor.TextChanged += new System.EventHandler(this.textNomeFornecedor_TextChanged);
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(422, 123);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(152, 20);
            this.textEndereco.TabIndex = 16;
            this.textEndereco.TextChanged += new System.EventHandler(this.textEndereco_TextChanged);
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(422, 150);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(152, 20);
            this.textTelefone.TabIndex = 17;
            this.textTelefone.TextChanged += new System.EventHandler(this.textTelefone_TextChanged);
            // 
            // textProdutos
            // 
            this.textProdutos.Location = new System.Drawing.Point(422, 177);
            this.textProdutos.Name = "textProdutos";
            this.textProdutos.Size = new System.Drawing.Size(152, 20);
            this.textProdutos.TabIndex = 18;
            this.textProdutos.TextChanged += new System.EventHandler(this.textProdutos_TextChanged);
            // 
            // Gravar
            // 
            this.Gravar.Location = new System.Drawing.Point(73, 405);
            this.Gravar.Name = "Gravar";
            this.Gravar.Size = new System.Drawing.Size(94, 23);
            this.Gravar.TabIndex = 19;
            this.Gravar.Text = "Gravar";
            this.Gravar.UseVisualStyleBackColor = true;
            this.Gravar.Click += new System.EventHandler(this.Gravar_Click);
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(245, 405);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(94, 23);
            this.Excluir.TabIndex = 20;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(412, 405);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(94, 23);
            this.Limpar.TabIndex = 21;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            // 
            // Erro_Msg
            // 
            this.Erro_Msg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Erro_Msg.AutoSize = true;
            this.Erro_Msg.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Erro_Msg.ForeColor = System.Drawing.Color.Red;
            this.Erro_Msg.Location = new System.Drawing.Point(67, 348);
            this.Erro_Msg.Name = "Erro_Msg";
            this.Erro_Msg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Erro_Msg.Size = new System.Drawing.Size(124, 34);
            this.Erro_Msg.TabIndex = 22;
            this.Erro_Msg.Text = "Msg Erro";
            this.Erro_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textCnpjMask
            // 
            this.textCnpjMask.Location = new System.Drawing.Point(422, 96);
            this.textCnpjMask.Name = "textCnpjMask";
            this.textCnpjMask.Size = new System.Drawing.Size(152, 20);
            this.textCnpjMask.TabIndex = 23;
            this.textCnpjMask.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textCnpjMask_MaskInputRejected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 466);
            this.Controls.Add(this.textCnpjMask);
            this.Controls.Add(this.Erro_Msg);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Gravar);
            this.Controls.Add(this.textProdutos);
            this.Controls.Add(this.textTelefone);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.textNomeFornecedor);
            this.Controls.Add(this.ProdutosFornecedor);
            this.Controls.Add(this.TelefoneFornecedor);
            this.Controls.Add(this.EnderecoFornecedor);
            this.Controls.Add(this.CnpjFornecedor);
            this.Controls.Add(this.NomeFornecedor);
            this.Controls.Add(this.TituloFornecedor);
            this.Controls.Add(this.TituloProduto);
            this.Controls.Add(this.textMedidaProduto);
            this.Controls.Add(this.textMarcaProduto);
            this.Controls.Add(this.MedidaProduto);
            this.Controls.Add(this.MarcaProduto);
            this.Controls.Add(this.textNomeProduto);
            this.Controls.Add(this.NomeProduto);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NomeProduto;
        private System.Windows.Forms.TextBox textNomeProduto;
        private System.Windows.Forms.Label MarcaProduto;
        private System.Windows.Forms.Label MedidaProduto;
        private System.Windows.Forms.TextBox textMarcaProduto;
        private System.Windows.Forms.TextBox textMedidaProduto;
        private System.Windows.Forms.Label TituloProduto;
        private System.Windows.Forms.Label TituloFornecedor;
        private System.Windows.Forms.Label NomeFornecedor;
        private System.Windows.Forms.Label CnpjFornecedor;
        private System.Windows.Forms.Label EnderecoFornecedor;
        private System.Windows.Forms.Label TelefoneFornecedor;
        private System.Windows.Forms.Label ProdutosFornecedor;
        private System.Windows.Forms.TextBox textNomeFornecedor;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.TextBox textProdutos;
        private System.Windows.Forms.Button Gravar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Label Erro_Msg;
        private System.Windows.Forms.MaskedTextBox textCnpjMask;
    }
}

