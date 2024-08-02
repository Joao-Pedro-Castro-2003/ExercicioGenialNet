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
        }

        private void btnLimparForn_Click(object sender, EventArgs e)
        {
            textNomeFornecedor.Text = "";
            textCnpjMask.Text = "";
            textCep.Text = "";
            textTelefone.Text = "";
            textProdutos.Text = "";
        }

        private void btnGravarForn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textNomeFornecedor.Text) ||
                string.IsNullOrEmpty(textEndereco.Text) ||
                string.IsNullOrEmpty(textTelefone.Text) ||
                string.IsNullOrEmpty(textProdutos.Text)
                )
            {
                MessageBox.Show("Todos os campos são obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string cnpj = textCnpjMask.Text;
            cnpj = Regex.Replace(cnpj, @"[^\d]", "");
            if (string.IsNullOrEmpty(cnpj) || cnpj.Length != 14)
            {
                MessageBox.Show("CNPJ do Fornecedor é um campo Obrigatório e deve estar totalmente preenchido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private async void textCep_TextChanged(object sender, EventArgs e)
        {
            if (textCep.TextLength == 8)
            {
                try
                {
                    var client = new RestClient(string.Format("https://viacep.com.br/ws/{0}/json/", textCep.Text));
                    var request = new RestRequest(Method.GET);
                    var response = await client.ExecuteAsync(request); 

                    if (response.IsSuccessful)
                    {
                        var endereco = JsonSerializer.Deserialize<Endereco>(response.Content);

                        if (endereco != null)
                        {
                            textEndereco.Text = $"{endereco.logradouro} - {endereco.Bairro} - {endereco.Localidade}"; //criar campos no Forms a colocar a base dos retornos
                        }
                        else
                        {
                            MessageBox.Show("Endereço não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar o endereço.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
