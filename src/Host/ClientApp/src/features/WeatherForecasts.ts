import { localhostApi } from "../app/localhostApi";
import { WeatherForecast } from "../entities/WeatherForecast";

const extendedApiSlice = localhostApi.injectEndpoints({
    endpoints: builder => ({
        weatherForecasts: builder.query<WeatherForecast[], number>({
            query: () => `weatherforecast`,
        })
    })
})


// Экспорт хуков (hook) для использования в функциональных компонентах (FC), 
// которые автоматически генерируются на основе определенных конечных точек (endpoints)
export const { useWeatherForecastsQuery } = extendedApiSlice 


