using System.Net;
using Domain.Model;
using Domain.Service;
using ServiceBus.Command.Handlers;
using ServiceBus.Command.Mapper;

namespace ServiceBus.Command.ServiceBus.PostMessage
{
    public class PostMessageHandle : IHandler
    {
        private readonly IServiceBusService _serviceBusService;

        public PostMessageHandle(IServiceBusService serviceBusService)
        {
            _serviceBusService = serviceBusService ?? throw new ArgumentNullException(nameof(serviceBusService));
        }

        public async Task<PostMessageResponse> Send(PostMessageRequest request)
        {
            // Verifica que la solicitud no sea nula antes de procesarla
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            // Aquí puedes utilizar el servicio de bus para enviar el mensaje
            await _serviceBusService.SendMessageAsync("queueName", PostMessageMapping.MapToQueueRequest(request));

            // Retorna una respuesta de éxito
            return new PostMessageResponse
            {
                HttpStatusCode = HttpStatusCode.OK.ToString(),
                ResponseMessage = "Message sent successfully."
            };
        }
    }
}
