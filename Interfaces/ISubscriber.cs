using RabbitMQ.Client.Service.Options;

namespace RabbitMQ.Client.Service.Interfaces
{
    public interface ISubscriber
    {
        public string Subscribe(ExchangeOptions exchangeOptions, QueueOptions queueOptions,ConsumeOptions consumeOptions);
    }
}
