using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using YAGO.WebProjectTemplate.Application.WeatherForecastService;
using YAGO.WebProjectTemplate.Domain.WeatherForecast;

namespace YAGO.WebProjectTemplate.Host.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private readonly WeatherForecastService _weatherForecastService;

		public WeatherForecastController(WeatherForecastService weatherForecastService)
		{
			_weatherForecastService = weatherForecastService;
		}

		[HttpGet]
		public Task<IEnumerable<WeatherForecast>> Get(CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();

			return _weatherForecastService.GetWeatherForecastList(cancellationToken);
		}
	}
}
