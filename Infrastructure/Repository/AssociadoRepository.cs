using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Context;
using System;
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
        public Int64 PostCadastroAssociado(Associado associado)
        {
            _context.Associados.Add(associado);
            _context.SaveChanges();
            return associado.Id;
        }

        public Associado GetCadastroAssociado(string email)
        {
            return _context.Associados.Where(a => a.Email.Equals(email)).FirstOrDefault();
        }

        public Associado GetCadastroAssociado(long id)
        {
            return _context.Associados.Where(a => a.Id == id).FirstOrDefault();
        }
    }
}
