namespace Domain.Model
{
    /// <summary>
    /// Modelo de mensaje utilizado para representar la información que se enviará a través del servicio de bus.
    /// </summary>
    public class MessageModel
    {
        /// <summary>
        /// Obtiene o establece el nombre del mensaje.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Obtiene o establece otras propiedades del mensaje, según sea necesario.
        /// </summary>
        public string? OtherProperty { get; set; }

    }
}
