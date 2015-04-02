using System;
using NServiceBus;
using OnTheBus.Messages.Commands;
using OnTheBus.Messages.Events;

namespace OnTheBus.Backend
{
    public class SayHelloCommandHandler
        : IHandleMessages<SayHelloCommand>
    {
        private readonly ISendOnlyBus _bus;

        public SayHelloCommandHandler(ISendOnlyBus bus)
        {
            _bus = bus;
        }

        public void Handle(SayHelloCommand message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*** Hello {0} ***", message.Name);
            Console.ResetColor();

            _bus.Publish(new SaidHelloEvent(){Name = message.Name});
        }
    }
}
