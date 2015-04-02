using System;
using NServiceBus;
using OnTheBus.Messages.Commands.Responses;

namespace OnTheBus.Client
{
    public class ReverseCommandResponseHandler : IHandleMessages<ReverseCommandResponse>
    {
        public void Handle(ReverseCommandResponse message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message.Result);
            Console.ResetColor();
        }
    }
}
