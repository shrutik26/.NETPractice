using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkerService1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddMassTransit(x =>
                    {
                        x.AddConsumer<OrderConsumer>();

                        x.UsingRabbitMq((context, cfg) =>
                        {
                            cfg.ConfigureEndpoints(context);
                            cfg.ReceiveEndpoint("Model:Order", e =>
                            {
                                e.Bind("amq.direct", x =>
                                {
                                    x.Durable = false;
                                    x.AutoDelete = true;
                                    x.RoutingKey = "8675309";
                                });
                            });
                        });
                    });
                    services.AddMassTransitHostedService(true);
                    services.AddHostedService<Worker>();
                });
    }
}
