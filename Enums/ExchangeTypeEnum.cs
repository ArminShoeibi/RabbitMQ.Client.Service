using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQ.Client.Service.Enums
{
    public enum ExchangeTypeEnum : byte
    {
        Direct = 1,
        Fanout,
        Headers,
        Topic,
    }
}
