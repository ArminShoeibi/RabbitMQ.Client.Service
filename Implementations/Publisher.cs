using RabbitMQ.Client.Service.Interfaces;
using RabbitMQ.Client.Service.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQ.Client.Service.Implementations
{
    public class Publisher : IPublisher
    {
        private readonly IAMQPChannelProvider _amqpChannelProvider;
        private readonly IModel _amqpChannel;
        public Publisher(IAMQPChannelProvider aMQPChannelProvider)
        {
            _amqpChannelProvider = aMQPChannelProvider;
            _amqpChannel = _amqpChannelProvider.GetAMQPChannel();
        }

        public void PublishMessage(ExchangeOptions exchangeOptions, string message, Dictionary<string, object> messageAttributes = null, string timeToLive = "30000")
        {
            byte[] messageBodyBytes = Encoding.UTF8.GetBytes(message);


            _amqpChannel.ExchangeDeclare(exchangeOptions.Name,
                                         exchangeOptions.Type.ToString().ToLower(),
                                         exchangeOptions.Durable,
                                         exchangeOptions.AutoDelete);

            IBasicProperties basicProperties = _amqpChannel.CreateBasicProperties();
            basicProperties.DeliveryMode = 2;
            basicProperties.Persistent = true;
            basicProperties.Expiration = timeToLive;
            basicProperties.ContentType = "application/json";
            if (messageAttributes is not null)
            {
                basicProperties.Headers = messageAttributes;
            }

            _amqpChannel.BasicPublish(exchangeOptions.Name, exchangeOptions.RoutingKey, basicProperties, messageBodyBytes);
        }

        public void Dispose()
        {
            _amqpChannelProvider.Dispose();
        }

    }
}
