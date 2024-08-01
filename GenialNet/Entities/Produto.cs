using GenialNet.Enums;

namespace GenialNet.Entities
{
    class Produto
    {
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }

        public Produto(string descricao, string marca, UnidadeMedida unidadeMedida)
        {
            UnidadeMedida = unidadeMedida;
        }
    }
}
