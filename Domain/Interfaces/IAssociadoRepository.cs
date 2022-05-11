using Domain.Models;
using System;

namespace Domain.Interfaces
{
    public interface IAssociadoRepository
    {
        Int64 PostCadastroAssociado(Associado associado);
        Associado GetCadastroAssociado(string email);
        Associado GetCadastroAssociado(long id);
    }
}
