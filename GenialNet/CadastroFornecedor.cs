using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using RestSharp.Serializers;
using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using GenialNet.Entities;
using static System.Net.Mime.MediaTypeNames;
using System.Text.Json;
using System.Data.SqlClient;
using GenialNet.DbConnection;
using GenialNet.Exceptions;

namespace GenialNet
{
    public partial class CadastroFornecedor : Form
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
        }
        private void CadastroFornecedor_Load(object sender, EventArgs e)
        {
            textCnpjMask.Mask = "00,000,000/0000-00";
            textTelefoneMask.Mask = "(00) 00000-0000";
            textCepMask.Mask = "00000-000";
        }
        private void btnLimparForn_Click(object sender, EventArgs e)
        {
            textNomeFornecedor.Text = "";
            textCnpjMask.Text = "";
            textCepMask.Text = "";
            textEndereco.Text = "";
            textTelefoneMask.Text = "";
        }
        private void btnGravarForn_Click(object sender, EventArgs e)
        {
            try
            {
                ConsisteGravacao();
                Endereco endereco = new Endereco(FormataApenasDigitos(textCepMask.Text),
                                                 textEndereco.Text.Split('-')[0].Trim(),
                                                 textEndereco.Text.Split('-')[1].Trim(),
                                                 textEndereco.Text.Split('-')[2].Trim(),
                                                 textEndereco.Text.Split('-')[3].Trim()
                                                 );

                Fornecedor fornecedor = new Fornecedor(textNomeFornecedor.Text, FormataApenasDigitos(textCnpjMask.Text), FormataApenasDigitos(textTelefoneMask.Text), endereco);

                VerificaDuplicidadeFornecedor(FormataApenasDigitos(textCnpjMask.Text));

                var enderecoId = InsereEndereco(endereco);

                InserirFornecedor(fornecedor, enderecoId);

                btnLimparForn_Click(sender, e);

                MessageBox.Show("Fornecedor cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Consistencias ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConsisteGravacao()
        {
            if (string.IsNullOrEmpty(textNomeFornecedor.Text.Trim()) ||
                string.IsNullOrEmpty(textEndereco.Text.Trim()) ||
                string.IsNullOrEmpty(FormataApenasDigitos(textTelefoneMask.Text.Trim())) ||
                string.IsNullOrEmpty(FormataApenasDigitos(textCepMask.Text).Trim())
                )
            {
                throw new Consistencias("Todos os campos são obrigatórios.");
            }

            string cnpj = FormataApenasDigitos(textCnpjMask.Text);

            if (string.IsNullOrEmpty(cnpj) || cnpj.Length != 14)
            { 
                throw new Consistencias("CNPJ do Fornecedor é um campo Obrigatório e deve estar totalmente preenchido.");
            }
        }
        private string FormataApenasDigitos(string textoFormatado)
        {
            return Regex.Replace(textoFormatado, @"[^\d]", "");
        }
        private void InserirFornecedor(Fornecedor fornecedor, int enderecoId)
        {
            var insertFornecedorQuery = @"INSERT INTO Fornecedores (nome, cnpj, telefone, endereco_id) 
                                          VALUES (@Nome, @Cnpj, @Telefone, @EnderecoId)";
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand cmdFornecedor = new SqlCommand(insertFornecedorQuery, conn))
                    {
                        cmdFornecedor.Parameters.AddWithValue("@Nome", fornecedor.Nome);
                        cmdFornecedor.Parameters.AddWithValue("@Cnpj", fornecedor.Cnpj);
                        cmdFornecedor.Parameters.AddWithValue("@Telefone", fornecedor.Telefone);
                        cmdFornecedor.Parameters.AddWithValue("@EnderecoId", enderecoId);
                        cmdFornecedor.ExecuteNonQuery();
                    }
                }  
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método: 'InserirFornecedor'" + ex.Message);
            }
            
        }
        private int InsereEndereco(Endereco endereco)
        {
            var insertEnderecoQuery = @"INSERT INTO Enderecos (cep, logradouro, bairro, localidade, uf) 
                                        VALUES (@Cep, @Logradouro, @Bairro, @Localidade, @Uf); 
                                        SELECT CAST(scope_identity() AS int)";

            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(insertEnderecoQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Cep", endereco.cep);
                        cmd.Parameters.AddWithValue("@Logradouro", endereco.logradouro);
                        cmd.Parameters.AddWithValue("@Bairro", endereco.bairro);
                        cmd.Parameters.AddWithValue("@Localidade", endereco.localidade);
                        cmd.Parameters.AddWithValue("@Uf", endereco.uf);

                        // Executar o comando e obter o ID inserido
                        int enderecoId = (int)cmd.ExecuteScalar();

                        return enderecoId;
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Ocorreu um erro no método: InsereEndereco: {ex.Message}");
            }
        }
        private void VerificaDuplicidadeFornecedor(string cnpj)
        {
            var query = "SELECT COUNT(1) FROM Fornecedores WHERE cnpj = @Cnpj";
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Cnpj", cnpj);
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            throw new Consistencias("Um fornecedor com esse CNPJ já existe");
                        }
                    }
                }
            }
            catch (Consistencias ex)
            {
                throw new Exception(ex.Message);
            }
            catch(Exception ex)
            {
                throw new Exception($"Ocorreu um erro no método VerificaDuplicidadeFornecedor: {ex.Message}");
            }
            
        }
        private async void textCepMask_TextChanged(object sender, EventArgs e)
        {
            if (FormataApenasDigitos(textCepMask.Text).Length == 8)
            {
                try
                {
                    var client = new RestClient(string.Format("https://viacep.com.br/ws/{0}/json/", FormataApenasDigitos(textCepMask.Text)));
                    var request = new RestRequest(Method.GET);
                    var response = await client.ExecuteAsync(request);

                    if (response.IsSuccessful)
                    {
                        var endereco = JsonSerializer.Deserialize<Endereco>(response.Content);

                        if (endereco != null)
                        {
                            textEndereco.Text = $"{endereco.logradouro} - {endereco.bairro} - {endereco.localidade} - {endereco.uf}";
                        }
                        else
                        {
                            throw new Consistencias("Endereço não encontrado.");
                        }
                    }
                    else
                    {
                        throw new Consistencias("Erro ao buscar o endereço.");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro na requisição de da API ViaCEP" + ex.Message);
                }
            }
        }
        private void btnPesquisarForn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta o formulário atual
            PesquisaFornecedor pesquisaFornecedor = new PesquisaFornecedor();
            pesquisaFornecedor.ShowDialog(); // Abre Form2 de maneira modal
            this.Show(); // Mostra o formulário atual novamente após Form2 ser fechado
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
