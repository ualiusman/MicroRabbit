﻿using MediatR;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.CommandHandlers;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Infa.Bus;
using Microsoft.Extensions.DependencyInjection;
using MiroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            service.AddTransient<IEventBus, RabbitMQBus>();

            service.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            service.AddTransient<IAcccountService, AccountService>();
            service.AddTransient<IAccountRepository, AccountRepository>();
            service.AddTransient<BankingDbContext>();
            service.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}
