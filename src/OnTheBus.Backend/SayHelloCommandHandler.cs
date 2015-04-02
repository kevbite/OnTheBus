using System;
using NServiceBus;
using OnTheBus.Messages.Commands;

namespace OnTheBus.Backend
{
    public class SayHelloCommandHandler
        : IHandleMessages<SayHelloCommand>
    {
        public void Handle(SayHelloCommand message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*** Hello {0} ***", message.Name);
            Console.ResetColor();
        }
    }
}
