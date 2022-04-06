using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModel.Response
{
    public class ResponseContaBancoViewModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("banco_id")]
        public int BancoId { get; set; }

        [JsonProperty("agencia")]
        public string Agencia { get; set; }

        [JsonProperty("digito_agencia")]
        public string DigitoAgencia { get; set; }

        [JsonProperty("conta")]
        public string Conta { get; set; }

        [JsonProperty("digito_conta")]
        public string DigitoConta { get; set; }

        [JsonProperty("tipo_conta")]
        public string TipoConta { get; set; }

    }
}
