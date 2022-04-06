using Application.Interface;
using Application.ViewModel.Request;
using Application.ViewModel.Response;
using AutoMapper;
using Domain.Interfaces;
using Domain.Interfaces.RabbitMQ;
using Domain.Models;
using System;

namespace Application.Services
{
    public class AssociadoAppService : Base, IAssociadoAppService
    {
        private readonly IMapper _mapper;
        private readonly IAssociadoRepository _associadoRepository;
        private readonly IPlanoRepository _planoRepository;
        private readonly IPlanoFaixaEtariaRepository _planoFaixaEtariaRepository;
        private readonly IAssociadoPublisher _associadoPublisher;



        public AssociadoAppService(IMapper mapper, IAssociadoRepository associadoRepository, IPlanoRepository planoRepository, IPlanoFaixaEtariaRepository planoFaixaEtariaRepository, IAssociadoPublisher associadoPublisher)
        {
            _mapper = mapper;
            _associadoRepository = associadoRepository;
            _planoRepository = planoRepository;
            _planoFaixaEtariaRepository = planoFaixaEtariaRepository;
            _associadoPublisher = associadoPublisher;
        }

        public int GetCadastroAssociado(int id)
        {
            throw new NotImplementedException();
        }

        public ResponseAssociadoViewModel PostCadastroAssociado(PostAssociadoViewModel postAssociadoView)
        {

            Associado associado = _mapper.Map<Associado>(postAssociadoView);
            Plano plano = _planoRepository.GetPlano(postAssociadoView.PlanoId);
            PlanoFaixaEtaria planoFaixaEtaria = _planoFaixaEtariaRepository.GetPlanoFaixaEtaria(plano.Id, postAssociadoView.DataNascimento);
            AssociadoPlano associadoPlano = new AssociadoPlano(associado, plano, planoFaixaEtaria);
            associado.AdicionarPlano(associadoPlano);

            _associadoRepository.PostCadastroAssociado(associado);
            _associadoPublisher.PublicarAssociado(associado);

            ResponseAssociadoViewModel responseAssociado = _mapper.Map<ResponseAssociadoViewModel>(associado);
            return responseAssociado;
        }


        protected override void Disposing(bool disposing)
        {
            base.Disposing(disposing);
        }
    }
}
