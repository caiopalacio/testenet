using System.ComponentModel.DataAnnotations;

namespace teste.Data
{
    public class ListaImoveis
    {
        public int Id { get; set; }
        public string TipoImovel { get; set; }
        public decimal ValorVenda { get; set; }
        public decimal ValorLocacao { get; set; }
        public decimal Area { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int Cep { get; set; }

    }
}
