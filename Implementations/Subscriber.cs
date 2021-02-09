using RabbitMQ.Client.Events;
using RabbitMQ.Client.Service.Interfaces;
using RabbitMQ.Client.Service.Options;
using System;
using System.Text;

namespace RabbitMQ.Client.Service.Implementations
{
    public class Subscriber : ISubscriber
    {
        private readonly IAMQPChannelProvider _amqpChannelProvider;
        private IModel amqpChannel;
        public Subscriber(IAMQPChannelProvider amqpChannelProvider)
        {
            _amqpChannelProvider = amqpChannelProvider;
        }
        public string Subscribe(ExchangeOptions exchangeOptions, QueueOptions queueOptions,bool autoAck)
        {
            amqpChannel = _amqpChannelProvider.GetAMQPChannel();

            amqpChannel.ExchangeDeclare(exchangeOptions.Name,
                exchangeOptions.Type.ToString().ToLower(),
                exchangeOptions.Durable, 
                exchangeOptions.AutoDelete);

            amqpChannel.QueueDeclare(queueOptions.Name,
                queueOptions.Durable,
                queueOptions.Exclusive,
                queueOptions.AutoDelete,
                null);

            var consumer = new EventingBasicConsumer(amqpChannel);
            consumer.Received += (sender,e) => 
            {
                var messageBody = e.Body.ToArray();
                var message = Encoding.UTF8.GetString(messageBody);
            };

           amqpChannel.BasicConsume(queueOptions.Name, autoAck, consumer);
        }

    }
}
