using Domain.Models;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface ITelefoneRepository
    {
        public void PostTelefone(List<Telefone> telefones, long associadoId);
    }
}
