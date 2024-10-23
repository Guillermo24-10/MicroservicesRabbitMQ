using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime timestamp { get; protected set; }

        protected Command()
        {
            timestamp = DateTime.Now;
        }
    }
}
