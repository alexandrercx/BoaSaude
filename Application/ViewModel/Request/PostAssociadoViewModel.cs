using Newtonsoft.Json;

namespace Application.ViewModel.Request
{
    public class PostAssociadoViewModel
    {

        [JsonProperty("associado_id")]
        public int Id { get; set; }


        [JsonProperty("nome")]
        public string Nome { get; set; }
    }
}
