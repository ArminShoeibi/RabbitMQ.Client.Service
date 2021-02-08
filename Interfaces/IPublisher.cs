using RabbitMQ.Client.Service.Options;
using System;
using System.Collections.Generic;

namespace RabbitMQ.Client.Service.Interfaces
{
    public interface IPublisher
    {
        void PublishMessage(ExchangeOptions exchangeOptions,
                            string message,
                            Dictionary<string, object> messageAttributes,
                            string timeToLive = "30000");

    }
}
