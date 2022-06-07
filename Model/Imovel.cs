using System.ComponentModel.DataAnnotations;


namespace teste.Model

{
    public class Imovel
    {
        
            
        [Required(ErrorMessage = "Id Obrigatório")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Tipo de Imóvel Obrigatório")]
        public string TipoImovel { get; set; }
        [Required(ErrorMessage = "Valor de Venda Obrigatório")]
        public decimal ValorVenda { get; set; }
        [Required(ErrorMessage = "Valor de Locação Obrigatório")]
        public decimal ValorLocacao { get; set; }
        [Required(ErrorMessage = "Área de Construção Obrigatório")]
        public decimal Area { get; set; }
        [Required(ErrorMessage = "Endereço Obrigatório")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "Número Obrigatório")]
        public int Numero { get; set; }
        [Required(ErrorMessage = "Complemento Obrigatório")]
        public string Complemento { get; set; }
        [Required(ErrorMessage = "Bairro Obrigatório")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "Cidade Obrigatório")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "CEP Obrigatório")]
        public int Cep { get; set; }


    }
}
