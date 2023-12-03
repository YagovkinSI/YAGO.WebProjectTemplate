using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using YAGO.WebProjectTemplate.Application.WeatherForecastService;
using YAGO.WebProjectTemplate.Domain.WeatherForecast;
using YAGO.WebProjectTemplate.Host.Models;

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
		public async Task<IEnumerable<WeatherForecastApi>> Get(CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();

			var weatherForecasts = await _weatherForecastService.GetWeatherForecastList(cancellationToken);

			return weatherForecasts
				.Select(w => ToApi(w));
		}

		private static WeatherForecastApi ToApi(WeatherForecast weatherForecast)
		{
			return new WeatherForecastApi
			(
				weatherForecast.Date,
				weatherForecast.Temperature,
				weatherForecast.Summary
			);
		}
	}
}
