namespace GenialNet
{
    partial class CadastroFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TituloFormForn = new System.Windows.Forms.Label();
            this.btnPesquisarForn = new System.Windows.Forms.Button();
            this.textCnpjMask = new System.Windows.Forms.MaskedTextBox();
            this.textProdutos = new System.Windows.Forms.TextBox();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.textCep = new System.Windows.Forms.TextBox();
            this.textNomeFornecedor = new System.Windows.Forms.TextBox();
            this.ProdutosFornecedor = new System.Windows.Forms.Label();
            this.TelefoneFornecedor = new System.Windows.Forms.Label();
            this.CepFornecedor = new System.Windows.Forms.Label();
            this.CnpjFornecedor = new System.Windows.Forms.Label();
            this.NomeFornecedor = new System.Windows.Forms.Label();
            this.btnGravarForn = new System.Windows.Forms.Button();
            this.btnLimparForn = new System.Windows.Forms.Button();
            this.EnderecoFornecedor = new System.Windows.Forms.Label();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TituloFormForn
            // 
            this.TituloFormForn.AutoSize = true;
            this.TituloFormForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloFormForn.Location = new System.Drawing.Point(141, 9);
            this.TituloFormForn.Name = "TituloFormForn";
            this.TituloFormForn.Size = new System.Drawing.Size(308, 31);
            this.TituloFormForn.TabIndex = 0;
            this.TituloFormForn.Text = "Cadastro de Fornecedor";
            // 
            // btnPesquisarForn
            // 
            this.btnPesquisarForn.BackColor = System.Drawing.SystemColors.Control;
            this.btnPesquisarForn.Location = new System.Drawing.Point(419, 349);
            this.btnPesquisarForn.Name = "btnPesquisarForn";
            this.btnPesquisarForn.Size = new System.Drawing.Size(117, 35);
            this.btnPesquisarForn.TabIndex = 1;
            this.btnPesquisarForn.Text = "Pesquisar";
            this.btnPesquisarForn.UseVisualStyleBackColor = false;
            // 
            // textCnpjMask
            // 
            this.textCnpjMask.Location = new System.Drawing.Point(147, 108);
            this.textCnpjMask.Name = "textCnpjMask";
            this.textCnpjMask.Size = new System.Drawing.Size(294, 20);
            this.textCnpjMask.TabIndex = 34;
            // 
            // textProdutos
            // 
            this.textProdutos.Location = new System.Drawing.Point(147, 229);
            this.textProdutos.Name = "textProdutos";
            this.textProdutos.Size = new System.Drawing.Size(294, 20);
            this.textProdutos.TabIndex = 33;
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(147, 198);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(294, 20);
            this.textTelefone.TabIndex = 32;
            // 
            // textCep
            // 
            this.textCep.Location = new System.Drawing.Point(147, 135);
            this.textCep.Name = "textCep";
            this.textCep.Size = new System.Drawing.Size(294, 20);
            this.textCep.TabIndex = 31;
            this.textCep.TextChanged += new System.EventHandler(this.textCep_TextChanged);
            // 
            // textNomeFornecedor
            // 
            this.textNomeFornecedor.Location = new System.Drawing.Point(147, 81);
            this.textNomeFornecedor.Name = "textNomeFornecedor";
            this.textNomeFornecedor.Size = new System.Drawing.Size(294, 20);
            this.textNomeFornecedor.TabIndex = 30;
            // 
            // ProdutosFornecedor
            // 
            this.ProdutosFornecedor.AutoSize = true;
            this.ProdutosFornecedor.Location = new System.Drawing.Point(27, 232);
            this.ProdutosFornecedor.Name = "ProdutosFornecedor";
            this.ProdutosFornecedor.Size = new System.Drawing.Size(52, 13);
            this.ProdutosFornecedor.TabIndex = 29;
            this.ProdutosFornecedor.Text = "Produtos:";
            // 
            // TelefoneFornecedor
            // 
            this.TelefoneFornecedor.AutoSize = true;
            this.TelefoneFornecedor.Location = new System.Drawing.Point(27, 201);
            this.TelefoneFornecedor.Name = "TelefoneFornecedor";
            this.TelefoneFornecedor.Size = new System.Drawing.Size(52, 13);
            this.TelefoneFornecedor.TabIndex = 28;
            this.TelefoneFornecedor.Text = "Telefone:";
            // 
            // CepFornecedor
            // 
            this.CepFornecedor.AutoSize = true;
            this.CepFornecedor.Location = new System.Drawing.Point(27, 138);
            this.CepFornecedor.Name = "CepFornecedor";
            this.CepFornecedor.Size = new System.Drawing.Size(29, 13);
            this.CepFornecedor.TabIndex = 27;
            this.CepFornecedor.Text = "Cep:";
            // 
            // CnpjFornecedor
            // 
            this.CnpjFornecedor.AutoSize = true;
            this.CnpjFornecedor.Location = new System.Drawing.Point(27, 111);
            this.CnpjFornecedor.Name = "CnpjFornecedor";
            this.CnpjFornecedor.Size = new System.Drawing.Size(37, 13);
            this.CnpjFornecedor.TabIndex = 26;
            this.CnpjFornecedor.Text = "CNPJ:";
            // 
            // NomeFornecedor
            // 
            this.NomeFornecedor.AutoSize = true;
            this.NomeFornecedor.Location = new System.Drawing.Point(27, 84);
            this.NomeFornecedor.Name = "NomeFornecedor";
            this.NomeFornecedor.Size = new System.Drawing.Size(110, 13);
            this.NomeFornecedor.TabIndex = 25;
            this.NomeFornecedor.Text = "Nome do Fornecedor:";
            // 
            // btnGravarForn
            // 
            this.btnGravarForn.Location = new System.Drawing.Point(30, 349);
            this.btnGravarForn.Name = "btnGravarForn";
            this.btnGravarForn.Size = new System.Drawing.Size(107, 35);
            this.btnGravarForn.TabIndex = 35;
            this.btnGravarForn.Text = "Gravar";
            this.btnGravarForn.UseVisualStyleBackColor = true;
            this.btnGravarForn.Click += new System.EventHandler(this.btnGravarForn_Click);
            // 
            // btnLimparForn
            // 
            this.btnLimparForn.Location = new System.Drawing.Point(221, 349);
            this.btnLimparForn.Name = "btnLimparForn";
            this.btnLimparForn.Size = new System.Drawing.Size(121, 35);
            this.btnLimparForn.TabIndex = 37;
            this.btnLimparForn.Text = "Limpar";
            this.btnLimparForn.UseVisualStyleBackColor = true;
            this.btnLimparForn.Click += new System.EventHandler(this.btnLimparForn_Click);
            // 
            // EnderecoFornecedor
            // 
            this.EnderecoFornecedor.AutoSize = true;
            this.EnderecoFornecedor.Location = new System.Drawing.Point(27, 169);
            this.EnderecoFornecedor.Name = "EnderecoFornecedor";
            this.EnderecoFornecedor.Size = new System.Drawing.Size(56, 13);
            this.EnderecoFornecedor.TabIndex = 38;
            this.EnderecoFornecedor.Text = "Endereço:";
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(147, 166);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(294, 20);
            this.textEndereco.TabIndex = 39;
            // 
            // CadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.EnderecoFornecedor);
            this.Controls.Add(this.btnLimparForn);
            this.Controls.Add(this.btnGravarForn);
            this.Controls.Add(this.textCnpjMask);
            this.Controls.Add(this.textProdutos);
            this.Controls.Add(this.textTelefone);
            this.Controls.Add(this.textCep);
            this.Controls.Add(this.textNomeFornecedor);
            this.Controls.Add(this.ProdutosFornecedor);
            this.Controls.Add(this.TelefoneFornecedor);
            this.Controls.Add(this.CepFornecedor);
            this.Controls.Add(this.CnpjFornecedor);
            this.Controls.Add(this.NomeFornecedor);
            this.Controls.Add(this.btnPesquisarForn);
            this.Controls.Add(this.TituloFormForn);
            this.Name = "CadastroFornecedor";
            this.Text = "CadastroProduto";
            this.Load += new System.EventHandler(this.CadastroFornecedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloFormForn;
        private System.Windows.Forms.Button btnPesquisarForn;
        private System.Windows.Forms.MaskedTextBox textCnpjMask;
        private System.Windows.Forms.TextBox textProdutos;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.TextBox textCep;
        private System.Windows.Forms.TextBox textNomeFornecedor;
        private System.Windows.Forms.Label ProdutosFornecedor;
        private System.Windows.Forms.Label TelefoneFornecedor;
        private System.Windows.Forms.Label CepFornecedor;
        private System.Windows.Forms.Label CnpjFornecedor;
        private System.Windows.Forms.Label NomeFornecedor;
        private System.Windows.Forms.Button btnGravarForn;
        private System.Windows.Forms.Button btnLimparForn;
        private System.Windows.Forms.Label EnderecoFornecedor;
        private System.Windows.Forms.TextBox textEndereco;
    }
}