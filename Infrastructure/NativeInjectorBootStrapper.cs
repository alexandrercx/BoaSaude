using Application.Interface;
using Application.Services;
using Domain.Interfaces;
using Domain.Interfaces.RabbitMQ;
using Infrastructure.RabbitMQ;
using Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application
            services.AddScoped<IAssociadoAppService, AssociadoAppService>();

            //Infra
            services.AddScoped<IAssociadoRepository, AssociadoRepository>();
            services.AddScoped<IPlanoRepository, PlanoRepository>();
            services.AddScoped<IPlanoFaixaEtariaRepository, PlanoFaixaEtariaRepository>();
            services.AddScoped<IAssociadoPlanoRepository, AssociadoPlanoRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<ITelefoneRepository, TelefoneRepository>();
            services.AddScoped<IContaBancoRepository, ContaBancoRepository>();

            //Mensageria RabbitMQ
            services.AddScoped<IAssociadoPublisher, AssociadoPublisher>();


        }
    }
}
