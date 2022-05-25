using API.Models;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using UnitTests.Fixtures;

namespace UnitTests.Tests
{
    /// <summary>
    /// Testes utilizando o pacote FluentAssertions em alternativa a utilização da classe Assert
    /// </summary>
    public class CalculaJurosFluentAssertionsTest : IClassFixture<CalculaJurosFixture>
    {
        private readonly ICalculaJuros _calculaJuros;

        public CalculaJurosFluentAssertionsTest(CalculaJurosFixture fixture)
        {
            _calculaJuros = fixture.ServiceProvider.GetRequiredService<ICalculaJuros>();
        }

        [Fact(DisplayName = "Valida o tipo de retorno como double")]
        public void CalculaJuros_QuandoChamado_RetornaDouble()
        {
            double valorInicial = 850;
            int meses = 7;

            _calculaJuros.RetornaCalculoJuros(valorInicial, meses).Should().BeOfType(typeof(double));
        }

    }
}
