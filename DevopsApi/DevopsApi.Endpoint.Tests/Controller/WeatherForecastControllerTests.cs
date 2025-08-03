using DevopsApi.Endpoint.Controllers;

namespace DevopsApi.Endpoint.Tests.Controller;

public class WeatherForecastControllerTests
{

	private readonly WeatherForecastController _controller;
	public WeatherForecastControllerTests()
	{
		_controller = new WeatherForecastController();
	}
	[Fact]
	public void Get_ReturnsWeatherForecasts()
	{
		// Act
		var result = _controller.Get();

		// Assert
		Assert.NotNull(result);
		Assert.IsAssignableFrom<IEnumerable<WeatherForecast>>(result);
		Assert.NotEmpty(result);
	}
}
