using System.Linq;
using FluentAssertions;
using Xunit;

namespace tech_lab_github_api.unit.tests
{
    public class WeatherForecastProviderTests
    {
        [Fact]
        public void Always_Returns5Elements()
        {
            var sut = new WeatherForecastProvider();
            var result = sut.GetForecast();
            result.Count().Should().Be(5);
        }
    }
}
