namespace ServiceBus.Command.ServiceBus.PostMessage
{
    /// <summary>
    /// Representa la respuesta de la operación de envío de mensajes.
    /// </summary>
    public class PostMessageResponse
    {
        /// <summary>
        /// Obtiene el código de estado HTTP de la respuesta.
        /// </summary>
        public string? HttpStatusCode { get; set; }

        /// <summary>
        /// Obtiene el mensaje descriptivo de la respuesta.
        /// </summary>
        public string? ResponseMessage { get; set; }

        /// <summary>
        /// Crea una nueva instancia de la clase <see cref="PostMessageResponse"/>.
        /// </summary>
        public PostMessageResponse()
        {
        }

        /// <summary>
        /// Crea una nueva instancia de la clase <see cref="PostMessageResponse"/> con el código de estado HTTP y el mensaje especificados.
        /// </summary>
        /// <param name="httpStatusCode">El código de estado HTTP de la respuesta.</param>
        /// <param name="responseMessage">El mensaje descriptivo de la respuesta.</param>
        public PostMessageResponse(string httpStatusCode, string responseMessage)
        {
            HttpStatusCode = httpStatusCode;
            ResponseMessage = responseMessage;
        }
    }
}
