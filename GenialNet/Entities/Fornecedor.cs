using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenialNet.Entities
{
    class Fornecedor
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public Endereco Endereco { get; set; }
        public string Telefone { get; set; }
        public List<Produto> Produtos { get; set; }
        public Fornecedor(string nome, string cnpj, string telefone, Endereco endereco)
        {
            Nome = nome;
            Cnpj = cnpj;
            Telefone = telefone;
            Endereco = endereco;
        }
    }
}
