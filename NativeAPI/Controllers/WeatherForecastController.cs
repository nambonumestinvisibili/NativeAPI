using Microsoft.AspNetCore.Mvc;
using Native.Domain.Models;
using Native.Services;

namespace NativeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IRepositoryManager _repositoryManager;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IRepositoryManager repositoryManager)
        {
            _logger = logger;
            _repositoryManager = repositoryManager;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IEnumerable<Venue>> Get()
        {
            return await _repositoryManager.Venue.GetAll();
        }
    }
}