using ServiceBus.Command.ServiceBus.PostMessage;

namespace ServiceBus.Command.Handlers
{
    public interface IHandler
    {
        Task<PostMessageResponse> Send(PostMessageRequest request);
    }
}