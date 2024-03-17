using Microsoft.AspNetCore.Mvc;
using ServiceBus.Command.Handlers;
using ServiceBus.Command.ServiceBus.PostMessage;

namespace ServiceBus.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class ServiceBusController : ControllerBase
    {
        private readonly ILogger<ServiceBusController> _logger;
        private readonly IHandler _handler;

        public ServiceBusController(ILogger<ServiceBusController> logger, IHandler handler)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _handler = handler ?? throw new ArgumentNullException(nameof(handler));
        }

        /// <summary>
        /// Enviar mensaje atravez de service bus
        /// </summary>
        /// <param name="request">La solicitud de mensaje.</param>
        /// <returns>Un IActionResult representando el resultado de la operación.</returns>
        [HttpPost("sendMessages")]
        public async Task<IActionResult> Send([FromBody] PostMessageRequest request)
        {
            try
            {
                if (request == null)
                {
                    _logger.LogError("Invalid request: Request is null.");
                    return BadRequest("Invalid request: Request is null.");
                }

                await _handler.Send(request);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing request.");
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
