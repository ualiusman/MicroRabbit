using MicroRabbit.Infa.Bus;
using Microsoft.Extensions.DependencyInjection;
using MiroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            service.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
