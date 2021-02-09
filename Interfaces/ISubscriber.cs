using RabbitMQ.Client.Service.Options;

namespace RabbitMQ.Client.Service.Interfaces
{
    public interface ISubscriber
    {
        public void Subscribe(ExchangeOptions exchangeOptions, QueueOptions queueOptions, bool autoAck);
    }
}
