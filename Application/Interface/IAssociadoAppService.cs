using Application.ViewModel.Request;
using Application.ViewModel.Response;
using System;

namespace Application.Interface
{
    public interface IAssociadoAppService
    {

        ResponseAssociadoViewModel PostCadastroAssociado(PostAssociadoViewModel postAssociadoView);

        ResponseAssociadoViewModel GetCadastroAssociado(long id);

        ResponseAssociadoViewModel GetCadastroAssociado(string email);
    }
}
