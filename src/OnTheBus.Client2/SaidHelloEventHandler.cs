using System;
using OnTheBus.Messages.Events;
using NServiceBus;

namespace OnTheBus.Client2
{
    public class SaidHelloEventHandle
        : IHandleMessages<SaidHelloEvent>
    {
        public void Handle(SaidHelloEvent message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Someone said hello to {0}", message.Name);
            Console.ResetColor();
        }
    }
}
