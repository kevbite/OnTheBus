using System;
using System.Linq;
using System.Threading;
using NServiceBus;
using OnTheBus.Messages.Commands;
using OnTheBus.Messages.Commands.Responses;

namespace OnTheBus.Backend
{
    public class ReverseCommandHandler : IHandleMessages<ReverseCommand>
    {
        private readonly IBus _bus;

        public ReverseCommandHandler(IBus bus)
        {
            _bus = bus;
        }

        public void Handle(ReverseCommand message)
        {
            // Pretend to do some hard work...
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.Write("*");
            }

            var chars = message.Text.ToCharArray();
            Array.Reverse(chars);
            var reversedText = new string(chars);

            Console.WriteLine("Completed Reversing Text From {0} to {1}", message.Text, reversedText);
            
            var response = new ReverseCommandResponse() {Result = reversedText};
            _bus.Reply(response);
        }
    }
}
