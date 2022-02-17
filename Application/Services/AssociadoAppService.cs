using Application.Interface;
using Application.ViewModel.Request;
using AutoMapper;
using Domain.Interfaces;
using Domain.Models;
using System;

namespace Application.Services
{
    public class AssociadoAppService : Base, IAssociadoAppService
    {
        private readonly IMapper _mapper;
        private readonly IAssociadoRepository _associadoRepository;

        public AssociadoAppService(IMapper mapper, IAssociadoRepository associadoRepository)
        {
            _mapper = mapper;
            _associadoRepository = associadoRepository;
        }
        public int GetCadastroAssociado(int id)
        {
            throw new NotImplementedException();
        }

        public Int64 PostCadastroAssociado(PostAssociadoViewModel postAssociadoView)
        {
            Associado associado = _mapper.Map<Associado>(postAssociadoView);
            _associadoRepository.PostCadastroAssociado(associado);
            return associado.IdAssociado;
        }

        protected override void Disposing(bool disposing)
        {
            base.Disposing(disposing);
        }
    }
}
