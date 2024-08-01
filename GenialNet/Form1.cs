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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textCnpjMask.Mask = "00,000,000/0000-00";
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

        private void textNomeFornecedor_TextChanged(object sender, EventArgs e)
        {
            textNomeFornecedor.Text = textNomeFornecedor.Text.Trim();
        }

        private void textEndereco_TextChanged(object sender, EventArgs e)
        {
            textEndereco.Text = textEndereco.Text.Trim();
        }

        private void textTelefone_TextChanged(object sender, EventArgs e)
        {
            textTelefone.Text = textTelefone.Text.Trim();
        }

        private void textProdutos_TextChanged(object sender, EventArgs e)
        {
            textProdutos.Text = textProdutos.Text.Trim();
        }
        private void textCnpjMask_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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
                if (string.IsNullOrEmpty(textNomeFornecedor.Text))
                {
                    throw new Exception("Nome do Fornecedor é um campo Obrigatório");
                }

                string cnpj = textCnpjMask.Text;
                cnpj = Regex.Replace(cnpj, @"[^\d]", "");
                if (string.IsNullOrEmpty(cnpj) && cnpj.Length < 14)
                {
                    throw new Exception("CNPJ do Fornecedor é um campo Obrigatório");
                }
         
                if (string.IsNullOrEmpty(textEndereco.Text))
                {
                    throw new Exception("Endereço do Fornecedor é um campo Obrigatório");
                }
                if (string.IsNullOrEmpty(textTelefone.Text))
                {
                    throw new Exception("Telefone do Fornecedor é um campo Obrigatório");
                }
                if (string.IsNullOrEmpty(textProdutos.Text))
                {
                    throw new Exception("Produtos do Fornecedor é um campo Obrigatório");
                }
            }
            catch (Exception ex)
            {
                Erro_Msg.Text = ex.Message;
            }   
        }
        private bool ValidarCNPJ(string cnpj)
        {
            if (cnpj.Length != 14)
            {
                return false;
            }

            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCnpj = cnpj.Substring(0, 12);
            int soma = 0;

            for (int i = 0; i < 12; i++)
            {
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            }

            int resto = (soma % 11);
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            string digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;

            for (int i = 0; i < 13; i++)
            {
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            }

            resto = (soma % 11);
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }
    }
}
