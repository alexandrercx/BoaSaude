using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Application.ViewModel.Request
{
    public class PostAssociadoViewModel
    {

        [Required]
        [JsonProperty("nome")]
        public string Nome { get; set; }

        [Required]
        [JsonProperty("cpf")]
        public long CPF { get; set; }

        [Required]
        [JsonProperty("data_nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required]
        [JsonProperty("nome_mae")]
        public string NomeMae { get; set; }

        [JsonProperty("cns")]
        public long CNS { get; set; }

        [JsonProperty("pis_pasep")]
        public long PisPasep { get; set; }

        [Required]
        [JsonProperty("plano_id")]
        public long PlanoId { get; set; }

        [Required]
        [JsonProperty("email")]
        public string Email { get; set; }

        [Required]
        [JsonProperty("senha")]
        public string Senha { get; set; }

        public List<PostEnderecoViewModel> Enderecos { get; set; }

        public List<PostTelefoneViewModel> Telefones { get; set; }

    }
}
