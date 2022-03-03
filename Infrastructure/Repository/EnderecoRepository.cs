using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Context;
using System.Collections.Generic;

namespace Infrastructure.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        private readonly Contexto _context;
        public EnderecoRepository(Contexto context) : base(context)
        {
            _context = context;
        }

        public List<Endereco> PostEndereco(List<Endereco> endereco,long associadoId)
        {
            foreach (var ende in endereco)
            {
                ende.AssociadoId = associadoId;
                _context.Enderecos.Add(ende);
                _context.SaveChanges();
            }

            return endereco;

        }

    }
}
