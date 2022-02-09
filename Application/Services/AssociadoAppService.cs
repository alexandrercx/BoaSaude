using Application.Interface;
using Application.ViewModel.Request;
using System;

namespace Application.Services
{
    public class AssociadoAppService : Base, IAssociadoAppService
    {
        public int GetCadastroAssociado(int id)
        {
            throw new NotImplementedException();
        }

        public int PostCadastroAssociado(PostAssociadoViewModel postAssociadoView)
        {
            return 0;
        }

        protected override void Disposing(bool disposing)
        {
            base.Disposing(disposing);
        }
    }
}
