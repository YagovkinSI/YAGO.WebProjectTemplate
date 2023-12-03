using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using YAGO.WebProjectTemplate.Domain.WeatherForecast;

namespace YAGO.WebProjectTemplate.Application.WeatherForecastService
{
	/// <summary>
	/// Сервис получения прогноза погоды
	/// </summary>
	public class WeatherForecastService
	{
		private readonly string[] _summaries = new[]
		{
			"Ясно", "Облачно", "Пасмурно", "Дождь", "Ливень", "Град", "Гроза", "Снег"
		};

		/// <summary>
		/// Получение прогноза погоды на пять дней
		/// </summary>
		/// <param name="cancellationToken">ТОкен отмены</param>
		/// <returns>Прогноз погоды на пять дней</returns>
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
