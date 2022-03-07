using Microsoft.EntityFrameworkCore.Storage;
using System.Threading.Tasks;

namespace Domain.Interfaces.Uow
{
    public interface IUnitOfWork
    {
        IAssociadoRepository associadoRepository { get; }
        IPlanoRepository planoRepository { get; }
        IPlanoFaixaEtariaRepository planoFaixaEtariaRepository { get; }
        IAssociadoPlanoRepository associadoPlanoRepository { get; }
        IEnderecoRepository enderecoRepository { get; }
        ITelefoneRepository telefoneRepository { get; }
        IContaBancoRepository contaBancoRepository { get; }



        Task<IDbContextTransaction> BeginTran();

        Task Commit();

        Task Rollback();

        Task SaveChanges();


    }
}
