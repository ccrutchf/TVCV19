using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace VideoMonitoring.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VideoMonitoringController : ControllerBase
    {

        [HttpGet("startPatientStream/{targetId}")]
        public async Task<IActionResult> StartPatientStream(string targetId)
        {
            return Ok();
        }

        [HttpGet("endPatientStream/{targetId}")]
        public async Task<IActionResult> EndPatientStream(string targetId)
        {
            return Ok();
        }

        [HttpGet("startCaregiverStream/{targetId}")]
        public async Task<IActionResult> StartCaregiverStream(string targetId)
        {
            return Ok();
        }
    }
}
