using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Messaging.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        
        [HttpGet("sendTextMessage/{targetId}")]
        public async Task<IActionResult> SendTextMessage(string sourceId, string[] targetIds, string message)
        {
            return Ok();
        }

        [HttpGet("sendTextMessageSupervisor/{targetId}")]
        public async Task<IActionResult> SendTextMessageSupervisor(string sourceId, string message)
        {
            return Ok();
        }

        [HttpGet("alertSupervisor/{targetId}")]
        public async Task<IActionResult> AlertSupervisor(string targetId)
        {
            return Ok();
        }

        [HttpGet("sendMediaMessage/{targetId}")]
        public async Task<IActionResult> SendMediaMessage(string sourceId, string[] targetIds)
        {
            return Ok();
        }

        [HttpGet("sendMediaMessageSupervisor/{targetId}")]
        public async Task<IActionResult> SendMediaMessageSupervisor(string meta)
        {
            return Ok();
        }

    }
}
