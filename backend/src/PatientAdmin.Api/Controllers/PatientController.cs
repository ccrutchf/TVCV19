using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PatientAdmin.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController : Controller
    {
        private ILogger<PatientController> _logger;

        public PatientController(ILogger<PatientController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string name, string location, string caregiverID)
        {
            return Ok("Corona");
        }

        [HttpGet("admit")]
        public async Task<IActionResult> AdmitPatient(string name, string location, string caregiverID)
        {
            return Ok();
        }

        [HttpGet("discharge/{id}")]
        public async Task<IActionResult> DischargePatient(string id)
        {
            return Ok();
        }

        [HttpGet("setchart/{id}")]
        public async Task<IActionResult> SetPatientChart(string id, Dictionary<string,string> chart)
        {
            return Ok();
        }

        [HttpGet("registercaregiver/{name}")]
        public async Task<IActionResult> RegisterCareGiver(string name, string[] ids)
        {
            return Ok();
        }

        [HttpGet("readings/{id}")]
        public async Task<IActionResult> EnterPatientReadings(string id, Dictionary<string,string> chart)
        {
            return Ok();
        }

    }
}
