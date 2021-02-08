using RabbitMQ.Client.Service.Enums;

namespace RabbitMQ.Client.Service.Options
{
    public class ExchangeOptions
    {
        public string Name { get; set; }
        public ExchangeTypeEnum Type { get; set; }
        public bool Durable { get; set; }
        public bool AutoDelete { get; set; }
        public string RoutingKey { get; set; }
    }
}
