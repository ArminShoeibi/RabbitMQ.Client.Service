using RabbitMQ.Client.Service.Interfaces;
using RabbitMQ.Client.Service.Options;
using System;

namespace RabbitMQ.Client.Service.Implementations
{
    public class Subscriber : ISubscriber
    {
        private readonly IAMQPChannelProvider _amqpChannelProvider;

        public Subscriber(IAMQPChannelProvider amqpChannelProvider)
        {
            _amqpChannelProvider = amqpChannelProvider;
        }
        public string Subscribe(ExchangeOptions exchangeOptions, QueueOptions queueOptions, ConsumeOptions consumeOptions)
        {
            throw new NotImplementedException();
        }
    }
}
