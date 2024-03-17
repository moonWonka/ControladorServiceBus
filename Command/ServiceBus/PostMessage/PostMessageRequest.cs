namespace ServiceBus.Command.ServiceBus.PostMessage
{
    /// <summary>
    /// Representa la solicitud para la operación de envío de mensajes.
    /// </summary>
    public class PostMessageRequest
    {
        /// <summary>
        /// Obtiene o establece el nombre asociado al mensaje.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Obtiene o establece otra propiedad asociada al mensaje.
        /// </summary>
        public string? OtherProperty { get; set; }
    }
}
