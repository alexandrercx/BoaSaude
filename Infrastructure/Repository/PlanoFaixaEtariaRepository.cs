using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repository
{
    public class PlanoFaixaEtariaRepository : Repository<PlanoFaixaEtaria>, IPlanoFaixaEtariaRepository
    {
        private readonly Contexto _context;

        public PlanoFaixaEtariaRepository(Contexto context) : base(context)
        {
            _context = context;
        }


        public PlanoFaixaEtaria GetPlanoFaixaEtaria(long planoId, DateTime dataNascimento)
        {
            int idade = DateTime.Today.Year - dataNascimento.Year;
            return  _context.PlanoFaixaEtarias.Where(c => c.PlanoId == planoId 
                                            && idade >= c.IdadeInicial.Year 
                                            && idade <= c.IdadeFinal.Year).FirstOrDefault();
        }
    }
}
