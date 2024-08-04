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
            this.TituloCadForn = new System.Windows.Forms.Label();
            this.btnPesquisarForn = new System.Windows.Forms.Button();
            this.textCnpjMask = new System.Windows.Forms.MaskedTextBox();
            this.textNomeFornecedor = new System.Windows.Forms.TextBox();
            this.TelefoneFornecedor = new System.Windows.Forms.Label();
            this.CepFornecedor = new System.Windows.Forms.Label();
            this.CnpjFornecedor = new System.Windows.Forms.Label();
            this.NomeFornecedor = new System.Windows.Forms.Label();
            this.btnGravarForn = new System.Windows.Forms.Button();
            this.btnLimparForn = new System.Windows.Forms.Button();
            this.EnderecoFornecedor = new System.Windows.Forms.Label();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.textTelefoneMask = new System.Windows.Forms.MaskedTextBox();
            this.textCepMask = new System.Windows.Forms.MaskedTextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TituloCadForn
            // 
            this.TituloCadForn.AutoSize = true;
            this.TituloCadForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloCadForn.Location = new System.Drawing.Point(141, 9);
            this.TituloCadForn.Name = "TituloCadForn";
            this.TituloCadForn.Size = new System.Drawing.Size(308, 31);
            this.TituloCadForn.TabIndex = 0;
            this.TituloCadForn.Text = "Cadastro de Fornecedor";
            // 
            // btnPesquisarForn
            // 
            this.btnPesquisarForn.BackColor = System.Drawing.SystemColors.Control;
            this.btnPesquisarForn.Location = new System.Drawing.Point(316, 264);
            this.btnPesquisarForn.Name = "btnPesquisarForn";
            this.btnPesquisarForn.Size = new System.Drawing.Size(117, 35);
            this.btnPesquisarForn.TabIndex = 1;
            this.btnPesquisarForn.Text = "Pesquisar";
            this.btnPesquisarForn.UseVisualStyleBackColor = false;
            this.btnPesquisarForn.Click += new System.EventHandler(this.btnPesquisarForn_Click);
            // 
            // textCnpjMask
            // 
            this.textCnpjMask.Location = new System.Drawing.Point(147, 108);
            this.textCnpjMask.Name = "textCnpjMask";
            this.textCnpjMask.Size = new System.Drawing.Size(414, 20);
            this.textCnpjMask.TabIndex = 34;
            // 
            // textNomeFornecedor
            // 
            this.textNomeFornecedor.Location = new System.Drawing.Point(147, 81);
            this.textNomeFornecedor.Name = "textNomeFornecedor";
            this.textNomeFornecedor.Size = new System.Drawing.Size(414, 20);
            this.textNomeFornecedor.TabIndex = 30;
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
            this.btnGravarForn.Location = new System.Drawing.Point(30, 264);
            this.btnGravarForn.Name = "btnGravarForn";
            this.btnGravarForn.Size = new System.Drawing.Size(107, 35);
            this.btnGravarForn.TabIndex = 35;
            this.btnGravarForn.Text = "Gravar";
            this.btnGravarForn.UseVisualStyleBackColor = true;
            this.btnGravarForn.Click += new System.EventHandler(this.btnGravarForn_Click);
            // 
            // btnLimparForn
            // 
            this.btnLimparForn.Location = new System.Drawing.Point(169, 264);
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
            this.textEndereco.ReadOnly = true;
            this.textEndereco.Size = new System.Drawing.Size(414, 20);
            this.textEndereco.TabIndex = 39;
            // 
            // textTelefoneMask
            // 
            this.textTelefoneMask.Location = new System.Drawing.Point(147, 198);
            this.textTelefoneMask.Name = "textTelefoneMask";
            this.textTelefoneMask.Size = new System.Drawing.Size(414, 20);
            this.textTelefoneMask.TabIndex = 40;
            // 
            // textCepMask
            // 
            this.textCepMask.Location = new System.Drawing.Point(147, 135);
            this.textCepMask.Name = "textCepMask";
            this.textCepMask.Size = new System.Drawing.Size(414, 20);
            this.textCepMask.TabIndex = 41;
            this.textCepMask.TextChanged += new System.EventHandler(this.textCepMask_TextChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(461, 264);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 35);
            this.btnVoltar.TabIndex = 42;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // CadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 459);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.textCepMask);
            this.Controls.Add(this.textTelefoneMask);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.EnderecoFornecedor);
            this.Controls.Add(this.btnLimparForn);
            this.Controls.Add(this.btnGravarForn);
            this.Controls.Add(this.textCnpjMask);
            this.Controls.Add(this.textNomeFornecedor);
            this.Controls.Add(this.TelefoneFornecedor);
            this.Controls.Add(this.CepFornecedor);
            this.Controls.Add(this.CnpjFornecedor);
            this.Controls.Add(this.NomeFornecedor);
            this.Controls.Add(this.btnPesquisarForn);
            this.Controls.Add(this.TituloCadForn);
            this.Name = "CadastroFornecedor";
            this.Text = "CadastroProduto";
            this.Load += new System.EventHandler(this.CadastroFornecedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloCadForn;
        private System.Windows.Forms.Button btnPesquisarForn;
        private System.Windows.Forms.MaskedTextBox textCnpjMask;
        private System.Windows.Forms.TextBox textNomeFornecedor;
        private System.Windows.Forms.Label TelefoneFornecedor;
        private System.Windows.Forms.Label CepFornecedor;
        private System.Windows.Forms.Label CnpjFornecedor;
        private System.Windows.Forms.Label NomeFornecedor;
        private System.Windows.Forms.Button btnGravarForn;
        private System.Windows.Forms.Button btnLimparForn;
        private System.Windows.Forms.Label EnderecoFornecedor;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.MaskedTextBox textTelefoneMask;
        private System.Windows.Forms.MaskedTextBox textCepMask;
        private System.Windows.Forms.Button btnVoltar;
    }
}