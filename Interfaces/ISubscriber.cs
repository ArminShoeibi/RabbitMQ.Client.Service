using RabbitMQ.Client.Service.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ.Client.Service.Interfaces
{
    public interface ISubscriber
    {
        public string Subscribe(ExchangeOptions exchangeOptions, QueueOptions queueOptions);
    }
}
