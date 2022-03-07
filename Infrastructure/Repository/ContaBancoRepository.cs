using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Context;
using System.Collections.Generic;

namespace Infrastructure.Repository
{
    public class ContaBancoRepository : Repository<ContaBanco>, IContaBancoRepository
    {
        private readonly Contexto _context;

        public ContaBancoRepository(Contexto context) : base(context)
        {
            _context = context;
        }

        public ContaBanco PostContaBanco(ContaBanco contaBanco, long associadoId)
        {
            contaBanco.AssociadoId = associadoId;
            _context.ContaBancos.Add(contaBanco);
            _context.SaveChanges();

            return contaBanco;
        }
    }
}
