
using System.Threading;
using OnTheBus.Conventions;

namespace OnTheBus.Backend
{
    using NServiceBus;

    /*
		This class configures this endpoint as a Server. More information about how to configure the NServiceBus host
		can be found here: http://particular.net/articles/the-nservicebus-host
	*/
    public class EndpointConfig : IConfigureThisEndpoint
    {
        public void Customize(BusConfiguration configuration)
        {
            configuration.UsePersistence<InMemoryPersistence>();
            
            configuration.UseTransport<RabbitMQTransport>();
            
            configuration.Conventions().MyDefaultConventions();
        }
    }
}
