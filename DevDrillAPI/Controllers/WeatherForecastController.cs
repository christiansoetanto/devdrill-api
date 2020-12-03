using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevDrillAPI.Dto;
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
        readonly IConfiguration configuration;

        private readonly DevDrillDbContext dbContext;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IConfiguration configuration,
            DevDrillDbContext dbContext)
        {
            _logger = logger;
            this.configuration = configuration;
            this.dbContext = dbContext;
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
            var y = await dbContext.Users.Include(e => e.Instructor).ToListAsync();
            return Ok();
        }
    }
}