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
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1 - Say Hello?");
                Console.WriteLine("2 - Reverse text?");

                if (Console.ReadLine() == "1")
                {
                    SayHello();
                }
                else
                {
                    ReverseText();
                }
            }
        }

        private void ReverseText()
        {
            Console.WriteLine("Text to reverse?");
            var name = Console.ReadLine();

            var message = new ReverseCommand() { Text = name };
            _bus.Send(message);

            Console.WriteLine("Message Sent");
        }

        private void SayHello()
        {
            Console.WriteLine("Say hello to who?");
            var name = Console.ReadLine();

            var message = new SayHelloCommand() {Name = name};
            _bus.Send(message);

            Console.WriteLine("Message Sent");
        }

        public void Stop()
        {
        }
    }
}
