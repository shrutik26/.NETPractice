using MassTransit;
using Microsoft.Extensions.Logging;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService1
{
    public class OrderConsumer : IConsumer<Order>
    {

        private readonly ILogger<OrderConsumer> _logger;

        public OrderConsumer(ILogger<OrderConsumer> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<Order> context)
        {
            _logger.LogInformation("Received Text: {Text}", context.Message.Name);
            return Task.CompletedTask;
        }

    }
}
