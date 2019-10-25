using Microsoft.AspNetCore.Mvc;

namespace Teapot.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeapotController : ControllerBase
    {
        /// <summary>
        /// Brew coffee
        /// </summary>
        /// <remarks>
        /// The 'Hyper Text Coffee Pot Control Protocol (HTCPCP/1.0): Semantics and Content' specifies that
        /// any attempt to brew coffee with a teapot should result in the error code "418 I'm a teapot".
        /// </remarks>
        /// <response code="418">Any attempt to brew coffee results in the error code "418 I'm a teapot".</response>
        [HttpGet("BrewCoffee")]
        [HttpPost("BrewCoffee")]
        [ProducesResponseType(typeof(string), 418)]
        public IActionResult Get() => StatusCode(418, "I'm a teapot");
    }
}
