using System;
using Microsoft.AspNetCore.Mvc;

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