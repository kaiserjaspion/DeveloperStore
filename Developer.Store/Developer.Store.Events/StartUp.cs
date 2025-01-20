using Developer.Store.Events.Models;
using Microsoft.Extensions.DependencyInjection;
using Rebus.Bus;
using Rebus.Config;
using Rebus.Routing.TypeBased;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Events
{
    public class StartUp
    {
        public static void ConfigureRebus(IServiceCollection services)
        {
            services.AddRebus(configure => configure
                .Transport(t => t.UseRabbitMq("amqp://guest:guest@localhost", "my-queue"))
                .Routing(r => r.TypeBased().Map<SaleCreatedEvent>("my-queue")));
            var serviceProvider = services.BuildServiceProvider();
            var bus = serviceProvider.GetRequiredService<IBus>();
        }
        
    }
}
