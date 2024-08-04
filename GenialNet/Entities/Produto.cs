namespace GenialNet.Entities
{
    class Produto
    {
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public string UnidadeMedida { get; set; }

        public Produto(string descricao, string marca, string unidadeMedida)
        {
            Descricao = descricao;
            Marca = marca;
            UnidadeMedida = unidadeMedida;
        }
    }
}
