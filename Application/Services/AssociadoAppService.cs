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
        private readonly IPlanoRepository _planoRepository;
        private readonly IPlanoFaixaEtariaRepository _planoFaixaEtariaRepository;
        private readonly IAssociadoPlanoRepository _associadoPlanoRepository;
        private readonly IEnderecoRepository _enderecoRepository;
        private readonly ITelefoneRepository _telefoneRepository;
        private readonly IContaBancoRepository _contaBancoRepository;


        public AssociadoAppService(IMapper mapper, IAssociadoRepository associadoRepository, IPlanoRepository planoRepository, IPlanoFaixaEtariaRepository planoFaixaEtariaRepository, IAssociadoPlanoRepository associadoPlanoRepository, IEnderecoRepository enderecoRepository, ITelefoneRepository telefoneRepository, IContaBancoRepository contaBancoRepository)
        {
            _mapper = mapper;
            _associadoRepository = associadoRepository;
            _planoRepository = planoRepository;
            _planoFaixaEtariaRepository = planoFaixaEtariaRepository;
            _associadoPlanoRepository = associadoPlanoRepository;
            _enderecoRepository = enderecoRepository;
            _telefoneRepository = telefoneRepository;
            _contaBancoRepository = contaBancoRepository;
        }
        public int GetCadastroAssociado(int id)
        {
            throw new NotImplementedException();
        }

        public Int64 PostCadastroAssociado(PostAssociadoViewModel postAssociadoView)
        {
          
            Associado associado = _mapper.Map<Associado>(postAssociadoView);
            Plano plano = _planoRepository.GetPlano(postAssociadoView.PlanoId);
            PlanoFaixaEtaria planoFaixaEtaria = _planoFaixaEtariaRepository.GetPlanoFaixaEtaria(plano.Id, postAssociadoView.DataNascimento);
            AssociadoPlano associadoPlano = new AssociadoPlano(associado, plano, planoFaixaEtaria);
            associado.AdicionarPlano(associadoPlano);

            _associadoRepository.PostCadastroAssociado(associado);           
            return associado.Id;
        }


        protected override void Disposing(bool disposing)
        {
            base.Disposing(disposing);
        }
    }
}
