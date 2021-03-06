using API.Models;
using Microsoft.Extensions.DependencyInjection;
using UnitTests.Fixtures;

namespace UnitTests.Tests
{
    /// <summary>
    /// Testes utilizando Fact e Theory
    /// </summary>
    public class CalculaJurosTest : IClassFixture<CalculaJurosFixture>
    {
        private readonly ICalculaJuros _calculaJuros;

        public CalculaJurosTest(CalculaJurosFixture fixture)
        {
            _calculaJuros = fixture.ServiceProvider.GetRequiredService<ICalculaJuros>();
        }

        [Fact(DisplayName = "Valida o tipo de retorno como double")]
        public void CalculaJuros_QuandoChamado_RetornaDouble()
        {
            // Arrange
            double valorInicial = 100;
            int meses = 2;

            // Act
            double calculaJuros = _calculaJuros.RetornaCalculoJuros(valorInicial, meses);

            // Assert
            Assert.IsType<double>(calculaJuros);
        }

        [Theory(DisplayName = "Valida o cálculo dos juros")]
        [InlineData(100, 2, 102.01)]
        [InlineData(100, 3, 103.03)]
        [InlineData(100, 5, 105.10)]
        [InlineData(105, 2, 107.11)]
        [InlineData(105, 3, 108.18)]
        public void CalculaJuros_Valida_Calculo(double valorInicial, int meses, double valorEsperado)
        {
            // Act            
            double calculaJuros = _calculaJuros.RetornaCalculoJuros(valorInicial, meses);

            // Assert
            Assert.Equal(valorEsperado, calculaJuros);
        }

        [Theory(DisplayName = "Valida exceção do campo valor inicial")]
        [InlineData(0, 5)]
        [InlineData(-2, 5)]
        public void CalculaJuros_Valida_ValorInicial(double valorInicial, int meses)
        {
            // verifica a chamada da exceção
            Assert.Throws<Exception>(() => _calculaJuros.RetornaCalculoJuros(valorInicial, meses));
        }

        [Theory(DisplayName = "Valida exceção do campo meses")]
        [InlineData(150, -5)]
        [InlineData(500, 0)]
        public void CalculaJuros_Valida_Meses(double valorInicial, int meses)
        {
            // verifica a chamada da exceção
            Assert.Throws<Exception>(() => _calculaJuros.RetornaCalculoJuros(valorInicial, meses));
        }
    }
}
