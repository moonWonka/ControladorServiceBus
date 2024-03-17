using Domain.Model;

namespace Domain.Service
{
    /// <summary>
    /// Interfaz para el servicio que envía mensajes a un servicio de bus.
    /// </summary>
    public interface IServiceBusService
    {
        /// <summary>
        /// Envía un mensaje asincrónico a una cola específica del servicio de bus.
        /// </summary>
        /// <param name="queueName">Nombre de la cola a la que se enviará el mensaje.</param>
        /// <param name="message">Instancia del modelo de mensaje a enviar.</param>
        /// <returns>Una tarea que representa la operación asincrónica.</returns>
        Task SendMessageAsync(string queueName, MessageModel message);
    }
}
