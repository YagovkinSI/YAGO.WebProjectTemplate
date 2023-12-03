using System;

namespace YAGO.WebProjectTemplate.Domain.WeatherForecast
{
	/// <summary>
	/// Прогноз погоды
	/// </summary>
	public class WeatherForecast
	{
		/// <summary>
		/// Дата
		/// </summary>
		public DateTime Date { get; set; }

		/// <summary>
		/// Температура в градусах Цельсия
		/// </summary>
		public int TemperatureC { get; set; }

		/// <summary>
		/// Температура в градусах Фаренгейта
		/// </summary>
		public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

		/// <summary>
		/// Общее описание
		/// </summary>
		public string Summary { get; set; }
	}
}
