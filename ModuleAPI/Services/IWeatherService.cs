using ModuleAPI.Models;

namespace ModuleAPI.Services;

public interface IWeatherService
{
    IEnumerable<WeatherForecast> GetForecast();
}
