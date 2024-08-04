using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenialNet.ComboBox;
using GenialNet.DbConnection;
using GenialNet.Entities;
using GenialNet.Exceptions;
using RestSharp;
using RestSharp.Serializers;
using System.Globalization;
using System.Drawing.Text;

namespace GenialNet
{
    public partial class CadastroProduto : Form
    {
        private int IdFornecedor;
        private string NomeFornecedor;
        private int IdProduto;
        public CadastroProduto(int idFornecedor, string nomeFornecedor)
        {
            IdFornecedor = idFornecedor;
            NomeFornecedor = nomeFornecedor;
            InitializeComponent();
        }
        private void CadastroProduto_Load(object sender, EventArgs e)
        {
            TituloNomeFornecedor.Text = $"{NomeFornecedor} - Produtos";
            CentralizaTitulo();
            CarregarProdutos(IdFornecedor);
            CarregarComboUnidadesMedida();
        }
        private void Gravar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(textNomeProduto.Text, textMarcaProduto.Text, comboBoxUnidadeMedida.Text);
            try
            {
                ConsisteCampos();
                if (IdProduto != 0)
                {
                    VerificaDuplicidadeProduto(produto, IdFornecedor);
                    AlteraProduto(produto, IdFornecedor);
                    CarregarProdutos(IdFornecedor);
                    MessageBox.Show("Fornecedor Alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    VerificaDuplicidadeProduto(produto, IdFornecedor);
                    InsereProduto(produto);
                    CarregarProdutos(IdFornecedor);
                    Limpar_Click(sender, e);
                    MessageBox.Show("Fornecedor Inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Consistencias ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Gravar.Text = "Gravar";
                IdProduto = 0;
            }
        }
        private void VerificaDuplicidadeProduto(Produto produto, int IdFornecedor)
        {
            var query = @"SELECT COUNT(1) 
                  FROM Produtos_Fornecedores 
                  WHERE produto_id = (SELECT produto_id FROM Produtos 
                                            WHERE DESCRICAO = @Descricao AND 
                                            MARCA = @Marca AND 
                                            UNIDADE_MEDIDA = @UnidadeMedida)
                  AND fornecedor_id = @IdFornecedor";
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Descricao", produto.Descricao);
                        cmd.Parameters.AddWithValue("@Marca", produto.Marca);
                        cmd.Parameters.AddWithValue("@UnidadeMedida", produto.UnidadeMedida);
                        cmd.Parameters.AddWithValue("@IdFornecedor", IdFornecedor);
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            throw new Consistencias("Esse Produto já existe nesse fornecedor");
                        }
                    }
                }
            }
            catch (Consistencias ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro no método VerificaDuplicidadeFornecedor: {ex.Message}");
            }
        }
        private void CarregarProdutos(int IdFornecedor)
        {
            string connectionString = DatabaseConfig.GetConnectionString();
            string query = $@"SELECT p.produto_id, p.descricao, p.marca, p.unidade_medida, pf.valor_compra  
                              FROM produtos p inner join Produtos_Fornecedores pf on p.produto_id = pf.produto_id 
                              WHERE FORNECEDOR_ID = {IdFornecedor}";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable produtos = new DataTable();
                    adapter.Fill(produtos);
                    dataGridViewProdutos.DataSource = produtos;
                }
            }
        }
        private void ConsisteCampos()
        {
            if (string.IsNullOrEmpty(textNomeProduto.Text.Trim()) ||
                string.IsNullOrEmpty(textMarcaProduto.Text.Trim()) ||
                string.IsNullOrEmpty(comboBoxUnidadeMedida.Text.Trim()) ||
                string.IsNullOrEmpty(textValorCompra.Text.Trim())
                )
            {
                throw new Consistencias("Todos os campos são obrigatórios.");
            }
        }
        private void InsereProduto(Produto produto)
        {
            var sql1 = @"INSERT INTO PRODUTOS (descricao, marca, unidade_medida) 
                             VALUES (@Descricao, @Marca, @UnidadeMedida);
                             SELECT CAST(scope_identity() AS int);";

            var sql2 = @"INSERT INTO Produtos_Fornecedores (fornecedor_id, produto_id, valor_compra) 
                                       VALUES (@FornecedorId, @ProdutoId, @ValorCompra);";

            using (SqlConnection conn = new SqlConnection(DatabaseConfig.GetConnectionString()))
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Inserir produto e obter o ID gerado
                        int produtoId;
                        using (SqlCommand cmdProduto = new SqlCommand(sql1, conn, transaction))
                        {
                            cmdProduto.Parameters.AddWithValue("@Descricao", produto.Descricao);
                            cmdProduto.Parameters.AddWithValue("@Marca", produto.Marca);
                            cmdProduto.Parameters.AddWithValue("@UnidadeMedida", produto.UnidadeMedida);
                            produtoId = (int)cmdProduto.ExecuteScalar();
                        }

                        // Inserir relação fornecedor-produto
                        using (SqlCommand cmdFornecedorProduto = new SqlCommand(sql2, conn, transaction))
                        {
                            cmdFornecedorProduto.Parameters.AddWithValue("@FornecedorId", IdFornecedor);
                            cmdFornecedorProduto.Parameters.AddWithValue("@ProdutoId", produtoId);
                            cmdFornecedorProduto.Parameters.AddWithValue("@ValorCompra", textValorCompra.Text.Replace(",", "."));
                            cmdFornecedorProduto.ExecuteNonQuery();
                        }

                        // Commit da transação
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro no método: 'InsereProduto'" + ex.Message);
                    }
                }
            }
        }
        private void AlteraProduto(Produto produto, int fornecedorId)
        {
            var updateProdutoSql = $@"UPDATE PRODUTOS SET DESCRICAO = @Descricao, MARCA = @Marca, UNIDADE_MEDIDA = @UnidadeMedida WHERE PRODUTO_ID = @ProdutoId";
            var updateFornecedorProdutoSql = @"UPDATE Produtos_Fornecedores SET fornecedor_id = @FornecedorId, valor_compra = @ValorCompra WHERE produto_id = @ProdutoId";

            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Atualizar produto
                            using (SqlCommand cmdProduto = new SqlCommand(updateProdutoSql, conn, transaction))
                            {
                                cmdProduto.Parameters.AddWithValue("@ProdutoId", IdProduto);
                                cmdProduto.Parameters.AddWithValue("@Descricao", produto.Descricao);
                                cmdProduto.Parameters.AddWithValue("@Marca", produto.Marca);
                                cmdProduto.Parameters.AddWithValue("@UnidadeMedida", produto.UnidadeMedida);
                                cmdProduto.ExecuteNonQuery();
                            }

                            // Atualizar relação fornecedor-produto
                            using (SqlCommand cmdFornecedorProduto = new SqlCommand(updateFornecedorProdutoSql, conn, transaction))
                            {
                                cmdFornecedorProduto.Parameters.AddWithValue("@FornecedorId", fornecedorId);
                                cmdFornecedorProduto.Parameters.AddWithValue("@ProdutoId", IdProduto);
                                cmdFornecedorProduto.Parameters.AddWithValue("@ValorCompra", textValorCompra.Text);
                                cmdFornecedorProduto.ExecuteNonQuery();
                            }

                            // Commit da transação
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            // Rollback da transação em caso de erro
                            transaction.Rollback();
                            throw new Exception("Erro no método 'AlteraProduto': " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método 'AlteraProduto': " + ex.Message);
            }
        }
        private void CarregarComboUnidadesMedida()
        {
            string query = "SELECT id, descricao FROM UnidadeMedidas";
            using (SqlConnection conn = new SqlConnection(DatabaseConfig.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            // Adicione itens ao ComboBox
                            comboBoxUnidadeMedida.Items.Add(new ComboBoxItem
                            {
                                Text = reader["descricao"].ToString(),
                                Value = (int)reader["id"]
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar unidades de medida: {ex.Message}");
                }
            }
        }
        private void dataGridViewProdutos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Certifique-se de que a linha clicada não seja o cabeçalho
            {
                DataGridViewRow row = dataGridViewProdutos.Rows[e.RowIndex];

                int id = Convert.ToInt32(row.Cells["produto_id"].Value);
                string nome = row.Cells["descricao"].Value.ToString();
                string valorCompra = row.Cells["valor_compra"].Value.ToString().Replace(",", ".");
                string marca = row.Cells["marca"].Value.ToString();
                string unidadeMedida = row.Cells["unidade_medida"].Value.ToString();

                IdProduto = id;
                textNomeProduto.Text = nome;
                textMarcaProduto.Text = marca;
                textValorCompra.Text = valorCompra;
                comboBoxUnidadeMedida.Text = unidadeMedida;

                if (IdProduto != 0)
                {
                    Gravar.Text = "Alterar";
                }
            }
        }
        private void CentralizaTitulo()
        {
            TituloNomeFornecedor.Left = (this.ClientSize.Width - TituloNomeFornecedor.Width) / 2;
        }
        private void Limpar_Click(object sender, EventArgs e)
        {
            textNomeProduto.Text = "";
            textMarcaProduto.Text = "";
            comboBoxUnidadeMedida.Text = "";
            textValorCompra.Text = "";
            IdProduto = 0;
            Gravar.Text = "Gravar";
        }
        private void Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdProduto == 0)
                {
                    MessageBox.Show("Informe algum produto para ser excluído");
                }
                else
                {
                    ExcluirProduto(IdProduto);
                    CarregarProdutos(IdFornecedor);
                    MessageBox.Show("Fornecedor excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Consistencias ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                IdProduto = 0;
                Limpar_Click(sender, e);
            }

        }
        private void ExcluirProduto(int idProduto)
        {
            string deleteProdutoFornecedoresQuery = @"DELETE FROM Produtos_Fornecedores WHERE produto_id = @IdProduto";
            string deleteProdutoQuery = @"DELETE FROM Produtos WHERE produto_id = @IdProduto";

            using (SqlConnection conn = new SqlConnection(DatabaseConfig.GetConnectionString()))
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Primeiro, exclua as associações na tabela Produtos_Fornecedores
                        using (SqlCommand cmd = new SqlCommand(deleteProdutoFornecedoresQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@IdProduto", idProduto);
                            cmd.ExecuteNonQuery();
                        }

                        // Em seguida, exclua o produto na tabela Produtos
                        using (SqlCommand cmd = new SqlCommand(deleteProdutoQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@IdProduto", idProduto);
                            cmd.ExecuteNonQuery();
                        }

                        // Se tudo correr bem, commit a transação
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Se algo der errado, faça o rollback da transação
                        transaction.Rollback();
                        throw new Exception("Erro ao excluir o produto: " + ex.Message);
                    }
                }
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
