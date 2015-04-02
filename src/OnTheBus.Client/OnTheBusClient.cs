using System;
using NServiceBus;
using OnTheBus.Messages.Commands;

namespace OnTheBus.Client
{
    public class OnTheBusClient : IWantToRunWhenBusStartsAndStops
    {
        private readonly ISendOnlyBus _bus;

        public OnTheBusClient(ISendOnlyBus bus)
        {
            _bus = bus;
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Say hello to who?");
                var name = Console.ReadLine();

                var message = new SayHelloCommand() {Name = name};
                _bus.Send(message);

                Console.WriteLine("Message Sent");
            }
        }

        public void Stop()
        {
        }
    }
}
