using Domain.Models;

namespace Domain.Interfaces.RabbitMQ
{
    public interface IAssociadoPublisher
    {
        public void PublicarAssociado(Associado associado);
    }
}
