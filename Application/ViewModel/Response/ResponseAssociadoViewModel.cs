using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModel.Response
{
    public class ResponseAssociadoViewModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }

       
        [JsonProperty("cpf")]
        public long CPF { get; set; }

    
        [JsonProperty("data_nascimento")]
        public DateTime DataNascimento { get; set; }

      
        [JsonProperty("nome_mae")]
        public string NomeMae { get; set; }

        [JsonProperty("cns")]
        public long CNS { get; set; }

        [JsonProperty("pis_pasep")]
        public long PisPasep { get; set; }

      
        [JsonProperty("plano_id")]
        public long PlanoId { get; set; }

       
        [JsonProperty("email")]
        public string Email { get; set; }

       
        [JsonProperty("senha")]
        public string Senha { get; set; }

        public List<ResponseEnderecoViewModel> Enderecos { get; set; }

        public List<ResponseTelefoneViewModel> Telefones { get; set; }

        public ResponseContaBancoViewModel ContaBanco { get; set; }
    }
}
