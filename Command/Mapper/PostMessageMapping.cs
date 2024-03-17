using Domain.Model;
using ServiceBus.Command.ServiceBus.PostMessage;

namespace ServiceBus.Command.Mapper
{
    public static class PostMessageMapping
    {
        public static MessageModel MapToQueueRequest(PostMessageRequest request)
        {
            return new MessageModel
            {
                Name = request.Name,
                OtherProperty = request.OtherProperty
            };
        }
    }
}