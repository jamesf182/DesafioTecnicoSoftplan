using API2.ICollections;
using API2.Models;
using Microsoft.Extensions.DependencyInjection;

namespace API2Test.Fixture
{
    public class CalculaJurosFixture
    {
        public CalculaJurosFixture()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<ICalculaJuros, CalculaJurosModel>();

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }
        public ServiceProvider ServiceProvider { get; private set; }
    }
}
