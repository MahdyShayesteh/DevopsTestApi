using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace DevopsApi.Endpoint.Tests.IntegrationTest;

public class WeatherForecastIntegrationTests
{
	private readonly HttpClient _client;
	public WeatherForecastIntegrationTests()
	{
		var factory = new WebApplicationFactory<Program>()
			.WithWebHostBuilder(builder =>
			{
				builder.ConfigureServices(services =>
				{
					// Configure any necessary services for testing
				});
			});
		_client = factory.CreateClient();
	}

	[Fact]
	public async Task GetWeatherForecast_ReturnsSuccessStatusCode()
	{
		// Act
		var response = await _client.GetAsync("/WeatherForecast");
		// Assert
		response.EnsureSuccessStatusCode();
		var content = await response.Content.ReadAsStringAsync();
		Assert.NotEmpty(content);
	}
}
