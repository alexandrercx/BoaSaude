using Application.ViewModel.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interface
{
    public interface IAssociadoAppService
    {

        int PostCadastroAssociado(PostAssociadoViewModel postAssociadoView);

        int GetCadastroAssociado(PostAssociadoViewModel postAssociadoView);
    }
}
