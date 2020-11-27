using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace DevDrillAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        IConfiguration configuration;

        private readonly DevDrillDbContext dbContext;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IConfiguration configuration)
        {
            _logger = logger;
            this.configuration = configuration;
        }


        [HttpGet]
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


        [HttpGet("test")]
        public async Task<IActionResult> Test()
        {
            var x = await dbContext.Users.ToListAsync();
            return Ok(x);
        }

        [HttpGet("test2")]
        public async Task<IActionResult> Test2()
        {
            return Ok(configuration["SQLiteConnectionString"]);
        }

        [HttpGet("coba")]
        public async Task<IActionResult> Coba()
        {
            var x = await dbContext.Cobas.ToListAsync();
            if (x.Any()) return Ok(x);
            else return Ok("gk ada isi");
        }
    }
}