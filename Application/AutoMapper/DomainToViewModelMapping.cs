using Application.ViewModel.Response;
using AutoMapper;
using Domain.Models;

namespace Application.AutoMapper
{
    public class DomainToViewModelMapping : Profile
    {
        public DomainToViewModelMapping()
        {
            CreateMap<Associado, ResponseAssociadoViewModel>();
            CreateMap<Endereco, ResponseEnderecoViewModel>();
            CreateMap<Telefone, ResponseTelefoneViewModel>();
            CreateMap<ContaBanco, ResponseContaBancoViewModel>();
        }

    }
}
