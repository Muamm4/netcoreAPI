using Microsoft.AspNetCore.Mvc;
using ModuleAPI.Services;

namespace ModuleAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IWeatherService _weatherService;

    public WeatherForecastController(IWeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var forecast = _weatherService.GetForecast();
        return Ok(forecast);
    }

    [HttpGet("time")]
    public IActionResult ShowTime()
    {

        var obj = new
        {
            data = DateTime.Now.ToLongDateString(),
            hora = DateTime.Now.ToShortTimeString()
        };

        return Ok(obj);
    }
}
