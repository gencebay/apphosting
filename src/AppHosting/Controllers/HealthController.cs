using Microsoft.AspNetCore.Mvc;
using System;

namespace AppHosting.Controllers
{
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Environment.MachineName + " API alive and reachable.");
        }
    }
}
