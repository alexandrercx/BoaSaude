using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Application.ViewModel.Response
{
   public class ResponseTelefoneViewModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [Required]
        [JsonProperty("numero")]
        public string Numero { get; set; }

        [Required]
        [JsonProperty("ddi")]
        public string DDI { get; set; }

        [Required]
        [JsonProperty("ddd")]
        public string DDD { get; set; }

        [Required]
        [JsonProperty("tipo_telefone")]
        public string TipoTelefone { get; set; }
    }
}
