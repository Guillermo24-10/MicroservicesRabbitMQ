using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreateEvent>
    {
        private readonly ITransferRepository _transfer;

        public TransferEventHandler(ITransferRepository transfer)
        {
            _transfer = transfer;
        }

        public Task Handle(TransferCreateEvent @event)
        {
            var transaction = new TransferLog
            {
                FromAccount = @event.From,
                ToAccount = @event.To,
                TransferAmount = @event.Amount
            };

            _transfer.AddTransferLog(transaction);

            return Task.CompletedTask;  
        }
    }
}
