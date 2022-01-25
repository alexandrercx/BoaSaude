using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Infrastructure.Repository
{
    public class AssociadoRepository : Repository<Associado>, IAssociadoRepository
    {
        private readonly AppContext _context;

        public AssociadoRepository(AppContext context) : base(context)
        {
            _context = context;
        }
        public int PostCadastroAssociado()
        {
            Associado associado = _context.Associados.AsNoTracking().FirstOrDefault();
            return associado.Id;
        }
    }
}
