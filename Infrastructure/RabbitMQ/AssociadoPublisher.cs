using Domain.Interfaces.RabbitMQ;
using Domain.Models;
using RabbitMQ.Client;
using System;
using System.Text;
using System.Text.Json;

namespace Infrastructure.RabbitMQ
{
    public class AssociadoPublisher : IAssociadoPublisher
    {
        public void PublicarAssociado(Associado associado)
        {
            
            var factory = new ConnectionFactory()
            {
                HostName = "192.168.100.5",
                Port = AmqpTcpEndpoint.UseDefaultPort,
                UserName = "associado",
                Password = "associado"
            };

            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "AssociadoQueue",
                        durable: false,
                        exclusive: false,
                        autoDelete: false,
                        arguments: null);

                    string message = JsonSerializer.Serialize(associado);
                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(exchange: "",
                        routingKey: "AssociadoQueue",
                        basicProperties: null,
                        body: body);

                }


            }
        }
    }
}
