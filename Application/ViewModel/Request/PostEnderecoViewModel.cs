using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Application.ViewModel.Request
{
    public class PostEnderecoViewModel
    {
        [JsonProperty("endereco_id")]
        public long Id { get; set; }

        [Required]
        [JsonProperty("tipo_endereco")]
        public string TipoEndereco { get; set; }

        [Required]
        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }

        [Required]
        [JsonProperty("numero")]
        public string Numero { get; set; }

        [Required]
        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [Required]
        [JsonProperty("cidade")]
        public string Cidade { get; set; }

        [Required]
        [JsonProperty("cep")]
        public string CEP { get; set; }

        [Required]
        [JsonProperty("uf")]
        public string UF { get; set; }

        [JsonProperty("complemento")]
        public string Complemento { get; set; }

        [Required]
        [JsonProperty("pais")]
        public string Pais { get; set; }


    }
}
