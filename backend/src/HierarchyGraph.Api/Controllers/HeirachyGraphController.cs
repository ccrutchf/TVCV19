using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HierarchyGraph.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeirachyGraphController : ControllerBase
    {
        private readonly ILogger<HeirachyGraphController> _logger;

        public HeirachyGraphController(ILogger<HeirachyGraphController> logger)
        {
            _logger = logger;
        }

        [HttpGet("getHierarchy")]
        public async Task<IActionResult> GetHierarchy(string[] caregiverIds, string[] locations, string[] patientIds)
        {
            return Ok();
        }

        [HttpGet("setCommander/{id}")]
        public async Task<IActionResult> SetCommander(string id)
        {
            return Ok();
        }

        [HttpGet("registerCaregiver/{id}")]
        public async Task<IActionResult> RegisterCaregiver(string id)
        {
            return Ok();
        }

        [HttpGet("modifyCaregiver/{id}")]
        public async Task<IActionResult> ModifyCaregiver(string name, string[] ids)
        {
            return Ok();
        }

        [HttpGet("deleteCaregiver/{id}")]
        public async Task<IActionResult> DeleteCaregiver(string id)
        {
            return Ok();
        }
    }
}
