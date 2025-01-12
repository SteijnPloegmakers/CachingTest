using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CachingTest
{
    public class ForecastResult
    {
        public long ElapsedTime { get; }
        public IEnumerable<WeatherForecast> Forecasts { get; }

        public ForecastResult(IEnumerable<WeatherForecast> forecasts, long elapsedTime)
        {
            Forecasts = forecasts;
            ElapsedTime = elapsedTime;
        }
    }
}