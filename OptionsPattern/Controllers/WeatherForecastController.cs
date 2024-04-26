using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using OptionsPattern.Options;

namespace OptionsPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly AuthOptions _options;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IOptions<AuthOptions> options)
        {
            _logger = logger;
            _options = options.Value;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok($"Server: {_options.IdentityServer} - PrivateKey: {_options.IdentityKeys.PrivateKey} - PublicKey: {_options.IdentityKeys.PublicKey}");
        }
    }
}
