using Application.Command.PaymentMethod;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api")]
    public class PaymentMethodController : ControllerBase
    {
        private readonly ISender _sender;

        public PaymentMethodController(ISender sender)
        {
            _sender = sender ?? throw new ArgumentNullException(nameof(sender));
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create([FromBody] CreatePaymentMethodCommand command)
        {
            if (command == null)
            {
                return BadRequest("Command cannot be null.");
            }

            var result = await _sender.Send(command);

            return Ok(result);
        }
    }
}
