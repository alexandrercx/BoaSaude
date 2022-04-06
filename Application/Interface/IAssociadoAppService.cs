using Application.ViewModel.Request;
using Application.ViewModel.Response;
using System;

namespace Application.Interface
{
    public interface IAssociadoAppService
    {

        ResponseAssociadoViewModel PostCadastroAssociado(PostAssociadoViewModel postAssociadoView);

        int GetCadastroAssociado(int id);
    }
}
