using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public class TelefoneRepository : Repository<Telefone>, ITelefoneRepository
    {
        private readonly Contexto _context;
        public TelefoneRepository(Contexto context) : base(context)
        {
            _context = context;
        }

        public void PostTelefone(List<Telefone> telefones, long associadoId)
        {
            foreach (var tel in telefones)
            {
                tel.AssociadoId = associadoId;
                _context.Telefones.Add(tel);
               
            }
            _context.SaveChanges();
        }

    }
}
