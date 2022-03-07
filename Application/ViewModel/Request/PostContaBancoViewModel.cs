using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Application.ViewModel.Request
{
    public class PostContaBancoViewModel
    {
        [Required]
        [JsonProperty("banco_id")]
        public int BancoId { get; set; }

        [Required]
        [JsonProperty("agencia")]
        public string Agencia { get; set; }

        [JsonProperty("digito_agencia")]
        public string DigitoAgencia { get; set; }

        [Required]
        [JsonProperty("conta")]
        public string Conta { get; set; }

        [JsonProperty("digito_conta")]
        public string DigitoConta { get; set; }

        [Required]
        [JsonProperty("tipo_conta")]
        public string TipoConta { get; set; }
    }
}
