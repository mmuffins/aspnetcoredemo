using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_app.Controllers
{
    [ApiController]
    public class ProbesController : ControllerBase
    {
        [HttpGet("live")]
        public IActionResult LivenessProbe()
        {
            // Always return OK for demo purposes
            return Ok("Healthy");
        }

        [HttpGet("ready")]
        public IActionResult ReadinessProbe()
        {
            // Always return OK for demo purposes
            return Ok("Ready");
        }
    }
}
