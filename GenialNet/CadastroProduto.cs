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

namespace GenialNet
{
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }
        private void CadastroProduto_Load(object sender, EventArgs e)
        {

        }
        private void textNomeProduto_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textMarcaProduto_TextChanged(object sender, EventArgs e)
        {
            textMarcaProduto.Text = textMarcaProduto.Text.Trim();
        }
        private void textMedidaProduto_TextChanged(object sender, EventArgs e)
        {
            textMedidaProduto.Text = textMedidaProduto.Text.Trim();
        }

        private void Gravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textNomeProduto.Text))
                {
                    throw new Exception("Nome do Produto é um campo Obrigatório");
                }
                if (string.IsNullOrEmpty(textMarcaProduto.Text))
                {
                    throw new Exception("Marca do Produto é um campo Obrigatório");
                }
                if (string.IsNullOrEmpty(textMedidaProduto.Text))
                {
                    throw new Exception("Medida do Produto é um campo Obrigatório");
                }
                //UTILIZAR NO OUTRO BLOCO DE CODIGO
                //if (string.IsNullOrEmpty(textNomeFornecedor.Text))
                //{
                //    throw new Exception("Nome do Fornecedor é um campo Obrigatório");
                //}

                //string cnpj = textCnpjMask.Text;
                //cnpj = Regex.Replace(cnpj, @"[^\d]", "");
                //if (string.IsNullOrEmpty(cnpj) || cnpj.Length != 14)
                //{
                //    throw new Exception("CNPJ do Fornecedor é um campo Obrigatório");
                //}
         
                //if (string.IsNullOrEmpty(textEndereco.Text))
                //{
                //    throw new Exception("Endereço do Fornecedor é um campo Obrigatório");
                //}
                //if (string.IsNullOrEmpty(textTelefone.Text))
                //{
                //    throw new Exception("Telefone do Fornecedor é um campo Obrigatório");
                //}
                //if (string.IsNullOrEmpty(textProdutos.Text))
                //{
                //    throw new Exception("Produtos do Fornecedor é um campo Obrigatório");
                //}
            }
            catch (Exception ex)
            {
                Erro_Msg.Text = ex.Message;
            }   
        }
    }
}
