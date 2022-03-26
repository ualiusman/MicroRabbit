using MicroRabbit.Transfer.Domain.Events;
using MiroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TrasferCreatedEvent>
    {
        public TransferEventHandler()
        {

        }
        public Task Handle(TrasferCreatedEvent @event)
        {
            return Task.CompletedTask;
        }
    }
}
