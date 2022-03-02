using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Context;

namespace Infrastructure.Repository
{
    public class AssociadoPlanoRepository : Repository<AssociadoPlano>, IAssociadoPlanoRepository
    {
        private readonly Contexto _context;

        public AssociadoPlanoRepository(Contexto context) : base(context)
        {
            _context = context;
        }

        public long PostAssociadoPlano(AssociadoPlano associadoPlano)
        {
            _context.AssociadoPlanos.Add(associadoPlano);
            _context.SaveChanges();
            return associadoPlano.Id;
        }
    }
}
