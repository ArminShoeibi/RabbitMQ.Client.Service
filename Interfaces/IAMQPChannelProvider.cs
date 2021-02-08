using System;

namespace RabbitMQ.Client.Service.Interfaces
{
    public interface IAMQPChannelProvider : IDisposable
    {
        IModel GetAMQPChannel();
    }
}
