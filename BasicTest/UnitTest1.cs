using BasicAPI.Controllers;
using Microsoft.Extensions.Logging;

namespace BasicTest
{
    public class UnitTest1
    {
        [Fact]
        public void Get_ReturnsWeatherForecasts()
        {
            // Arrange
            var controller = new WeatherForecastController(null);

            // Act
            var result = controller.Get().ToList(); ;

            // Assert
            Assert.NotNull(result);

            // Check that the returned weather forecasts are not empty
            Assert.NotEmpty(result);

            // Check that there are exactly 5 weather forecasts returned
            Assert.Equal(5, result.Count);
        }
    }
}