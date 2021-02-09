namespace RabbitMQ.Client.Service.Options
{
    public class QueueOptions
    {
        public string Name { get; set; }
        public bool Durable { get; set; }
        public bool AutoDelete { get; set; }
        public bool Exclusive { get; set; }
    }
}
