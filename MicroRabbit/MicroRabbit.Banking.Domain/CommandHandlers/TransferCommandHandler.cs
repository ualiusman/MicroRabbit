using MediatR;
using MicroRabbit.Banking.Domain.Commands;
using MiroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.CommandHandlers
{
    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private IEventBus _bus;

        public TransferCommandHandler(IEventBus eventBus)
        {
            _bus = eventBus;
        }
        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(true);
        }
    }
}
