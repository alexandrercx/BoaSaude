using Newtonsoft.Json;

namespace Application.ViewModel.Request
{
    public class PostAssociadoViewModel
    {


        [JsonProperty("nome")]
        public string Nome { get; set; }
    }
}
