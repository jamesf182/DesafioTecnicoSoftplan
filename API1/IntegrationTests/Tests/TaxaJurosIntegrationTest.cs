using API1;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;

namespace IntegrationTests.Tests
{
    public class TaxaJurosIntegrationTest
    {
        private readonly HttpClient _client;

        public TaxaJurosIntegrationTest()
        {
            var server = new TestServer(new WebHostBuilder()
                .UseEnvironment("Development")
                .UseStartup<StartupApiTests>());

            _client = server.CreateClient();
        }

        [Theory]
        [InlineData("GET")]
        public async Task TaxaJuros_Integracao_Teste(string method)
        {
            // Arrange
            var request = new HttpRequestMessage(new HttpMethod(method), "/api/TaxaJuros");

            // Act
            var response = await _client.SendAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
