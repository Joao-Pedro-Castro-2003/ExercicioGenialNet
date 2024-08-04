using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            this.NomeProduto = new System.Windows.Forms.Label();
            this.textNomeProduto = new System.Windows.Forms.TextBox();
            this.MarcaProduto = new System.Windows.Forms.Label();
            this.MedidaProduto = new System.Windows.Forms.Label();
            this.textMarcaProduto = new System.Windows.Forms.TextBox();
            this.Gravar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.TituloNomeFornecedor = new System.Windows.Forms.Label();
            this.comboBoxUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.dataBaseGenialDataSet = new GenialNet.DataBaseGenialDataSet();
            this.dataBaseGenialDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseGenialDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedoresTableAdapter = new GenialNet.DataBaseGenialDataSetTableAdapters.FornecedoresTableAdapter();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.produto_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidade_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosPesqBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosPesq = new GenialNet.ProdutosPesq();
            this.SubTituloPesqForn = new System.Windows.Forms.Label();
            this.textValorCompra = new System.Windows.Forms.TextBox();
            this.Valor = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseGenialDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseGenialDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseGenialDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosPesqBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosPesq)).BeginInit();
            this.SuspendLayout();
            // 
            // NomeProduto
            // 
            this.NomeProduto.AutoSize = true;
            this.NomeProduto.Location = new System.Drawing.Point(34, 284);
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.Size = new System.Drawing.Size(92, 13);
            this.NomeProduto.TabIndex = 1;
            this.NomeProduto.Text = "Nome do produto:";
            // 
            // textNomeProduto
            // 
            this.textNomeProduto.Location = new System.Drawing.Point(193, 281);
            this.textNomeProduto.Name = "textNomeProduto";
            this.textNomeProduto.Size = new System.Drawing.Size(387, 20);
            this.textNomeProduto.TabIndex = 2;
            // 
            // MarcaProduto
            // 
            this.MarcaProduto.AutoSize = true;
            this.MarcaProduto.Location = new System.Drawing.Point(34, 310);
            this.MarcaProduto.Name = "MarcaProduto";
            this.MarcaProduto.Size = new System.Drawing.Size(40, 13);
            this.MarcaProduto.TabIndex = 3;
            this.MarcaProduto.Text = "Marca:";
            // 
            // MedidaProduto
            // 
            this.MedidaProduto.AutoSize = true;
            this.MedidaProduto.Location = new System.Drawing.Point(34, 339);
            this.MedidaProduto.Name = "MedidaProduto";
            this.MedidaProduto.Size = new System.Drawing.Size(45, 13);
            this.MedidaProduto.TabIndex = 4;
            this.MedidaProduto.Text = "Medida:";
            // 
            // textMarcaProduto
            // 
            this.textMarcaProduto.Location = new System.Drawing.Point(193, 307);
            this.textMarcaProduto.Name = "textMarcaProduto";
            this.textMarcaProduto.Size = new System.Drawing.Size(387, 20);
            this.textMarcaProduto.TabIndex = 5;
            // 
            // Gravar
            // 
            this.Gravar.Location = new System.Drawing.Point(32, 405);
            this.Gravar.Name = "Gravar";
            this.Gravar.Size = new System.Drawing.Size(94, 23);
            this.Gravar.TabIndex = 19;
            this.Gravar.Text = "Gravar";
            this.Gravar.UseVisualStyleBackColor = true;
            this.Gravar.Click += new System.EventHandler(this.Gravar_Click);
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(183, 405);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(94, 23);
            this.Excluir.TabIndex = 20;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(331, 405);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(94, 23);
            this.Limpar.TabIndex = 21;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // TituloNomeFornecedor
            // 
            this.TituloNomeFornecedor.AutoSize = true;
            this.TituloNomeFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloNomeFornecedor.Location = new System.Drawing.Point(285, 14);
            this.TituloNomeFornecedor.Name = "TituloNomeFornecedor";
            this.TituloNomeFornecedor.Size = new System.Drawing.Size(32, 31);
            this.TituloNomeFornecedor.TabIndex = 23;
            this.TituloNomeFornecedor.Text = "A";
            // 
            // comboBoxUnidadeMedida
            // 
            this.comboBoxUnidadeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnidadeMedida.FormattingEnabled = true;
            this.comboBoxUnidadeMedida.Location = new System.Drawing.Point(193, 336);
            this.comboBoxUnidadeMedida.Name = "comboBoxUnidadeMedida";
            this.comboBoxUnidadeMedida.Size = new System.Drawing.Size(387, 21);
            this.comboBoxUnidadeMedida.TabIndex = 24;
            // 
            // dataBaseGenialDataSet
            // 
            this.dataBaseGenialDataSet.DataSetName = "DataBaseGenialDataSet";
            this.dataBaseGenialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataBaseGenialDataSetBindingSource
            // 
            this.dataBaseGenialDataSetBindingSource.DataSource = this.dataBaseGenialDataSet;
            this.dataBaseGenialDataSetBindingSource.Position = 0;
            // 
            // dataBaseGenialDataSetBindingSource1
            // 
            this.dataBaseGenialDataSetBindingSource1.DataSource = this.dataBaseGenialDataSet;
            this.dataBaseGenialDataSetBindingSource1.Position = 0;
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "Fornecedores";
            this.fornecedoresBindingSource.DataSource = this.dataBaseGenialDataSetBindingSource1;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AllowUserToAddRows = false;
            this.dataGridViewProdutos.AutoGenerateColumns = false;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produto_id,
            this.descricao,
            this.valor_compra,
            this.marca,
            this.unidade_medida});
            this.dataGridViewProdutos.DataSource = this.produtosPesqBindingSource;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(37, 93);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.Size = new System.Drawing.Size(543, 166);
            this.dataGridViewProdutos.TabIndex = 25;
            this.dataGridViewProdutos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutos_CellContentDoubleClick);
            // 
            // produto_id
            // 
            this.produto_id.DataPropertyName = "produto_id";
            this.produto_id.HeaderText = "produto_id";
            this.produto_id.Name = "produto_id";
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descricao";
            this.descricao.Name = "descricao";
            // 
            // valor_compra
            // 
            this.valor_compra.DataPropertyName = "valor_compra";
            this.valor_compra.HeaderText = "valor_compra";
            this.valor_compra.Name = "valor_compra";
            // 
            // marca
            // 
            this.marca.DataPropertyName = "marca";
            this.marca.HeaderText = "marca";
            this.marca.Name = "marca";
            // 
            // unidade_medida
            // 
            this.unidade_medida.DataPropertyName = "unidade_medida";
            this.unidade_medida.HeaderText = "unidade_medida";
            this.unidade_medida.Name = "unidade_medida";
            // 
            // produtosPesqBindingSource
            // 
            this.produtosPesqBindingSource.DataSource = this.produtosPesq;
            this.produtosPesqBindingSource.Position = 0;
            // 
            // produtosPesq
            // 
            this.produtosPesq.DataSetName = "ProdutosPesq";
            this.produtosPesq.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SubTituloPesqForn
            // 
            this.SubTituloPesqForn.AutoSize = true;
            this.SubTituloPesqForn.Location = new System.Drawing.Point(158, 62);
            this.SubTituloPesqForn.Name = "SubTituloPesqForn";
            this.SubTituloPesqForn.Size = new System.Drawing.Size(308, 13);
            this.SubTituloPesqForn.TabIndex = 26;
            this.SubTituloPesqForn.Text = "(Dê 2 cliques em algum conteúdo para ser realizado a pesquisa)\r\n";
            // 
            // textValorCompra
            // 
            this.textValorCompra.Location = new System.Drawing.Point(193, 364);
            this.textValorCompra.Name = "textValorCompra";
            this.textValorCompra.Size = new System.Drawing.Size(387, 20);
            this.textValorCompra.TabIndex = 28;
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Location = new System.Drawing.Point(34, 367);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(73, 13);
            this.Valor.TabIndex = 29;
            this.Valor.Text = "Valor Compra:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(488, 405);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(92, 23);
            this.btnVoltar.TabIndex = 30;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 466);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.Valor);
            this.Controls.Add(this.textValorCompra);
            this.Controls.Add(this.SubTituloPesqForn);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.comboBoxUnidadeMedida);
            this.Controls.Add(this.TituloNomeFornecedor);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Gravar);
            this.Controls.Add(this.textMarcaProduto);
            this.Controls.Add(this.MedidaProduto);
            this.Controls.Add(this.MarcaProduto);
            this.Controls.Add(this.textNomeProduto);
            this.Controls.Add(this.NomeProduto);
            this.Name = "CadastroProduto";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CadastroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseGenialDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseGenialDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseGenialDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosPesqBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosPesq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NomeProduto;
        private System.Windows.Forms.TextBox textNomeProduto;
        private System.Windows.Forms.Label MarcaProduto;
        private System.Windows.Forms.Label MedidaProduto;
        private System.Windows.Forms.TextBox textMarcaProduto;
        private System.Windows.Forms.Button Gravar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Label TituloNomeFornecedor;
        private System.Windows.Forms.ComboBox comboBoxUnidadeMedida;
        private DataBaseGenialDataSet dataBaseGenialDataSet;
        private BindingSource dataBaseGenialDataSetBindingSource;
        private BindingSource dataBaseGenialDataSetBindingSource1;
        private BindingSource fornecedoresBindingSource;
        private DataBaseGenialDataSetTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
        private BindingSource produtosBindingSource;
        private DataGridView dataGridViewProdutos;
        private BindingSource produtosPesqBindingSource;
        private ProdutosPesq produtosPesq;
        private DataGridViewTextBoxColumn produto_id;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn valor_compra;
        private DataGridViewTextBoxColumn marca;
        private DataGridViewTextBoxColumn unidade_medida;
        private Label SubTituloPesqForn;
        private TextBox textValorCompra;
        private Label Valor;
        private Button btnVoltar;
    }
}

