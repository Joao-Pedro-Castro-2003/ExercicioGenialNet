namespace GenialNet
{
    partial class PesquisaFornecedor
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
            this.components = new System.ComponentModel.Container();
            this.TituloPesqForn = new System.Windows.Forms.Label();
            this.dataGridViewFornecedores = new System.Windows.Forms.DataGridView();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseGenialDataSet = new GenialNet.DataBaseGenialDataSet();
            this.fornecedoresTableAdapter = new GenialNet.DataBaseGenialDataSetTableAdapters.FornecedoresTableAdapter();
            this.SubTituloPesqForn = new System.Windows.Forms.Label();
            this.fornecedor_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseGenialDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TituloPesqForn
            // 
            this.TituloPesqForn.AutoSize = true;
            this.TituloPesqForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloPesqForn.Location = new System.Drawing.Point(226, 9);
            this.TituloPesqForn.Name = "TituloPesqForn";
            this.TituloPesqForn.Size = new System.Drawing.Size(309, 31);
            this.TituloPesqForn.TabIndex = 1;
            this.TituloPesqForn.Text = "Pesquisa de Fornecedor";
            // 
            // dataGridViewFornecedores
            // 
            this.dataGridViewFornecedores.AllowUserToAddRows = false;
            this.dataGridViewFornecedores.AutoGenerateColumns = false;
            this.dataGridViewFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fornecedor_id,
            this.nome,
            this.cnpj,
            this.telefone});
            this.dataGridViewFornecedores.DataSource = this.fornecedoresBindingSource;
            this.dataGridViewFornecedores.Location = new System.Drawing.Point(165, 79);
            this.dataGridViewFornecedores.Name = "dataGridViewFornecedores";
            this.dataGridViewFornecedores.ReadOnly = true;
            this.dataGridViewFornecedores.Size = new System.Drawing.Size(442, 237);
            this.dataGridViewFornecedores.TabIndex = 2;
            this.dataGridViewFornecedores.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFornecedores_CellContentDoubleClick);
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "Fornecedores";
            this.fornecedoresBindingSource.DataSource = this.dataBaseGenialDataSet;
            // 
            // dataBaseGenialDataSet
            // 
            this.dataBaseGenialDataSet.DataSetName = "DataBaseGenialDataSet";
            this.dataBaseGenialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // SubTituloPesqForn
            // 
            this.SubTituloPesqForn.AutoSize = true;
            this.SubTituloPesqForn.Location = new System.Drawing.Point(229, 49);
            this.SubTituloPesqForn.Name = "SubTituloPesqForn";
            this.SubTituloPesqForn.Size = new System.Drawing.Size(308, 13);
            this.SubTituloPesqForn.TabIndex = 3;
            this.SubTituloPesqForn.Text = "(Dê 2 cliques em algum conteúdo para ser realizado a pesquisa)\r\n";
            // 
            // fornecedor_id
            // 
            this.fornecedor_id.DataPropertyName = "fornecedor_id";
            this.fornecedor_id.HeaderText = "fornecedor_id";
            this.fornecedor_id.Name = "fornecedor_id";
            this.fornecedor_id.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // cnpj
            // 
            this.cnpj.DataPropertyName = "cnpj";
            this.cnpj.HeaderText = "cnpj";
            this.cnpj.Name = "cnpj";
            this.cnpj.ReadOnly = true;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(349, 322);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // PesquisaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.SubTituloPesqForn);
            this.Controls.Add(this.dataGridViewFornecedores);
            this.Controls.Add(this.TituloPesqForn);
            this.Name = "PesquisaFornecedor";
            this.Text = "PesquisaFornecedor";
            this.Load += new System.EventHandler(this.PesquisaFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseGenialDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloPesqForn;
        private System.Windows.Forms.DataGridView dataGridViewFornecedores;
        private DataBaseGenialDataSet dataBaseGenialDataSet;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private DataBaseGenialDataSetTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
        private System.Windows.Forms.Label SubTituloPesqForn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.Button btnVoltar;
    }
}