using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Context;
using System;
using System.Linq;

namespace Infrastructure.Repository
{
    public class PlanoRepository : Repository<Plano>, IPlanoRepository
    {
        private readonly Contexto _context;

        public PlanoRepository(Contexto context) : base(context)
        {
            _context = context;
        }

        public Plano GetPlano(long id)
        {
            return _context.Planos.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}
