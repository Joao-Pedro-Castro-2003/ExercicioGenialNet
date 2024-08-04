using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenialNet.Entities
{
    class Endereco
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string unidade { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }
        public string ddd { get; set; }
        public string siafi { get; set; }

        public Endereco(string cep, string logradouro, string bairro, string localidade, string uf)
        {
            this.cep = cep;
            this.logradouro = logradouro;
            this.bairro = bairro;
            this.localidade = localidade;
            this.uf = uf;
        }
    }
}
