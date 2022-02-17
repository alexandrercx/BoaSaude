using Application.ViewModel.Request;
using System;

namespace Application.Interface
{
    public interface IAssociadoAppService
    {

        Int64 PostCadastroAssociado(PostAssociadoViewModel postAssociadoView);

        int GetCadastroAssociado(int id);
    }
}
