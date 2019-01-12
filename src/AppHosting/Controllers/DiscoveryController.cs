using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;

namespace AppHosting.Controllers
{
    [Route("api/[controller]")]
    public class DiscoveryController : ControllerBase
    {
        private readonly IHostingEnvironment env;

        public DiscoveryController(IHostingEnvironment env)
        {
            this.env = env;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var host = new
            {
                MachineName = Environment.MachineName,
                DateTime = DateTime.Now.ToString(),
                IpAddress = Startup.GetLocalIPAddress(),
                EnvironmentName = env.EnvironmentName
            };

            return new JsonResult(host);
        }
    }
}
