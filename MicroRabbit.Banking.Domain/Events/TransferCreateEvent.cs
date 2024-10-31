using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Banking.Domain.Events
{
    internal class TransferCreateEvent : Event
    {
        public int From {  get; set; }  
        public int To { get; set; }
        public decimal Amount { get; set; }

        public TransferCreateEvent(int from, int to, decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
