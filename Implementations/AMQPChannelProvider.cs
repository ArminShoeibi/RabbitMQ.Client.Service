using RabbitMQ.Client.Service.Interfaces;
using RabbitMQ.Client.Service.Options;
using System;

namespace RabbitMQ.Client.Service.Implementations
{
    public class AMQPChannelProvider : IAMQPChannelProvider
    {
        private readonly ConnectionFactory _amqpConnectionFactory;
        private readonly IConnection _amqpConnection;
        private IModel _amqpChannel;
      
        public AMQPChannelProvider()
        {
            _amqpConnectionFactory = new ConnectionFactory()
            {
                UserName = ConnectionFactory.DefaultPass,
                Password = ConnectionFactory.DefaultUser,
                HostName = "localhost",
                Uri = new Uri("amqp://guest:guest@localhost:5672"), 
            };

             _amqpConnection = _amqpConnectionFactory.CreateConnection();
        }

        public IModel GetAMQPChannel()
        {
            _amqpChannel = _amqpConnection.CreateModel();
        
            return _amqpChannel;
        }

        public void Dispose()
        {
            _amqpChannel.Dispose();
            _amqpConnection.Dispose();

            /*Disposing channel and connection objects is not enough, they must be explicitly closed*/
            _amqpChannel.Close();
            _amqpConnection.Close();
        }
    }
}
