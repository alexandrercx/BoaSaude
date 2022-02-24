using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IPlanoFaixaEtariaRepository
    {
        PlanoFaixaEtaria GetPlanoFaixaEtaria(long planoId, DateTime dataNascimento);
    }
}
