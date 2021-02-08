using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ.Client.Service.Options
{
    public class QueueOptions
    {
        public string Name { get; set; }
        public bool Durable { get; set; }
        public bool AutoDelete { get; set; }
    }
}
