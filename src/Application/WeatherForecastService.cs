using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using YAGO.WebProjectTemplate.Domain;

namespace YAGO.WebProjectTemplate.Application
{
	public class WeatherForecastService
	{
		private readonly string[] _summaries = new[]
		{
			"Ясно", "Облачно", "Пасмурно", "Дождь", "Ливень", "Град", "Гроза", "Снег"
		};

		public Task<IEnumerable<WeatherForecast>> GetWeatherForecastList(CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();

			var rng = new Random();
			var result = Enumerable
				.Range(1, 5)
				.Select(index => new WeatherForecast
				{
					Date = DateTime.Now.AddDays(index),
					TemperatureC = rng.Next(-20, 55),
					Summary = _summaries[rng.Next(_summaries.Length)]
				});

			return Task.FromResult(result);
		}
	}
}
