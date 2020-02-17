using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.HeaderParameter.Extension;

namespace SampleApp9000.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [HeaderParameter(Name = "Content-Disposition", Required = true, Example = "inline", Type = "string")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet]
        [HeaderParameter(Name = "From", Required = false, Example = "user@sampleapp9000.com", Type = "string", Format = "email")]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        [HeaderParameter(Name = "Content-Type", Required = true, Example = "application/json", Type = "string")]
        public async Task<IActionResult> Post([FromBody] WeatherForecast _)
        {
            return 
                await 
                    Task.FromResult(Ok());
        }
    }
}
