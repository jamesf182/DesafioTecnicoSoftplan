using API.Models;
using API2.Models;
using Microsoft.Extensions.DependencyInjection;

namespace UnitTests.Fixtures
{
    public class CalculaJurosFixture
    {
        public CalculaJurosFixture()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<ICalculaJuros, CalculaJurosModel>();

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }
        public ServiceProvider ServiceProvider { get; private set; }
    }
}
