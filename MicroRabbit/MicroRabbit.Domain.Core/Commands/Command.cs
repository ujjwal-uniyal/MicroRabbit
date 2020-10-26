using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MicroRabbit.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; }  // only those who inherit from this class should be able to set the timestamp

        protected Command()
        {
            Timestamp = DateTime.UtcNow;
        }
    }
}
