using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Infrastructure.Repository
{
    public class AssociadoRepository : Repository<Associado>, IAssociadoRepository
    {
        private readonly Contexto _context;

        public AssociadoRepository(Contexto context) : base(context)
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
