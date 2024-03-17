using Domain.Model;
using Domain.Service;

namespace Infraestructure.Service
{
    public sealed class ServiceBusService : IServiceBusService
    {
        private readonly IConfiguration _configuration;
        public ServiceBusService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public Task SendMessageAsync(string queueName, MessageModel message)
        {
            throw new NotImplementedException();
        }
    }
}