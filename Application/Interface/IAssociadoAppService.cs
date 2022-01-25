using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interface
{
    public interface IAssociadoAppService
    {

        bool PostCadastroAssociado();

        int GetCadastroAssociado(int AssociadoId);
    }
}
