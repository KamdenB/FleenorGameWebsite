using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")] // Sets the url end point - i.e. [controller] sets to the default, but you could have it be "wf"
    public class APIController : ControllerBase
    {

        private readonly ILogger<APIController> _logger;

        public APIController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            
        }
    }
}
