using Domain.Models;

namespace Domain.Interfaces
{
    public interface IPlanoRepository
    {
        Plano GetPlano(long id);
    }
}
