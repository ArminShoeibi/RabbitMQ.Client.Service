using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ.Client.Service.Options
{
    public class ConsumeOptions
    {
        public bool AutoAcknowledge { get; set; }
        public bool Exclusive { get; set; }
        public Dictionary<string,object> ConsumeAttributes { get; set; }
        public IBasicConsumer Consumer { get; set; }
    }
}
