namespace GenialNet
{
    partial class CadastroProduto
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
            this.Gravar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.Erro_Msg = new System.Windows.Forms.Label();
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
            this.TituloProduto.Location = new System.Drawing.Point(67, 13);
            this.TituloProduto.Name = "TituloProduto";
            this.TituloProduto.Size = new System.Drawing.Size(109, 31);
            this.TituloProduto.TabIndex = 7;
            this.TituloProduto.Text = "Produto";
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
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 466);
            this.Controls.Add(this.Erro_Msg);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Gravar);
            this.Controls.Add(this.TituloProduto);
            this.Controls.Add(this.textMedidaProduto);
            this.Controls.Add(this.textMarcaProduto);
            this.Controls.Add(this.MedidaProduto);
            this.Controls.Add(this.MarcaProduto);
            this.Controls.Add(this.textNomeProduto);
            this.Controls.Add(this.NomeProduto);
            this.Name = "CadastroProduto";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CadastroProduto_Load);
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
        private System.Windows.Forms.Button Gravar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Label Erro_Msg;
    }
}

