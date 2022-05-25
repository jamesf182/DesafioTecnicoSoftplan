﻿using API;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;

namespace IntegrationTest
{
    public class CalculaJurosAPITest
    {
        private readonly HttpClient _client;

        public CalculaJurosAPITest()
        {
            var server = new TestServer(new WebHostBuilder()
                .UseEnvironment("Development")
                .UseStartup<StartupApiTests>());
            _client = server.CreateClient();
        }

        [Theory]
        [InlineData("GET", 100, 5)]
        public async Task AlbumGetAllTestAsync(string method, double valorInicial, int meses)
        {
            // Arrange
            var request = new HttpRequestMessage(new HttpMethod(method), string.Format("/api/CalculaJuros/?valorInicial={0}&meses={1}", valorInicial, meses));

            // Act
            var response = await _client.SendAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
