using Application.Interface;
using System;

namespace Application.Services
{
    public class AssociadoAppService : Base, IAssociadoAppService
    {
        public int GetCadastroAssociado(int AssociadoId)
        {

            return 0;
        }

        public bool PostCadastroAssociado()
        {
            throw new NotImplementedException();
        }

        protected override void Disposing(bool disposing)
        {
            base.Disposing(disposing);
        }
    }
}
