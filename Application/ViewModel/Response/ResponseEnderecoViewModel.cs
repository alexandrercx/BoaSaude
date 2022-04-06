using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModel.Response
{
    public class ResponseEnderecoViewModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("tipo_endereco")]
        public string TipoEndereco { get; set; }

       
        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }

       
        [JsonProperty("numero")]
        public string Numero { get; set; }

      
        [JsonProperty("bairro")]
        public string Bairro { get; set; }

      
        [JsonProperty("cidade")]
        public string Cidade { get; set; }

       
        [JsonProperty("cep")]
        public string CEP { get; set; }

       
        [JsonProperty("uf")]
        public string UF { get; set; }

        [JsonProperty("complemento")]
        public string Complemento { get; set; }

       
        [JsonProperty("pais")]
        public string Pais { get; set; }
    }
}
