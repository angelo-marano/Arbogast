using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Neo4j.Driver;

namespace Arbogast.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IDriver _driver;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IDriver driver)
        {
            _logger = logger;
            _driver = driver;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            var session = _driver.AsyncSession();
            var cursor = await session.RunAsync(@"MATCH (tom {name: 'Tom Hanks'}) RETURN tom.name as name");
            var record = await cursor.SingleAsync();
            var tom = record["name"].As<string>();
            return tom;
        }
    }
}
