using Domain.Models;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IEnderecoRepository
    {
        public List<Endereco> PostEndereco(List<Endereco> endereco, long associadoId);
    }
}
