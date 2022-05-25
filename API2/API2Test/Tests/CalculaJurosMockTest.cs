using API.Models;
using Moq;
using NSubstitute;

namespace UnitTests.Tests
{
    /// <summary>
    /// Mock de testes utilizando NSubstitute e Moq
    /// </summary>
    public class CalculaJurosMockTest
    {
        [Fact(DisplayName = "Valida o cálculo dos juros com NSubstitute")]
        public void CalculaJuros_Valida_Calculo_NSub()
        {
            // cria objeto mock
            var calculaJuros = Substitute.For<ICalculaJuros>();

            // valores de entrada para teste
            double valorInicial = 100;
            int meses = 5;

            // efetua o teste e assegura que o retorno é um double
            calculaJuros.RetornaCalculoJuros(valorInicial, meses).Returns(new double { });

            // confrima que o método foi executado uma única vez
            calculaJuros.Received(1);
        }

        [Fact(DisplayName = "Valida o cálculo dos juros com Moq")]
        public void CalculaJuros_Valida_Calculo_Moq()
        {
            // cria objeto mock
            var calculaJuros = new Mock<ICalculaJuros>();

            // valores de entrada para teste
            double valorInicial = 100;
            int meses = 5;

            // efetua o cálculo dos juros
            calculaJuros.Object.RetornaCalculoJuros(valorInicial, meses);

            // confirma que o método foi executado uma única vez
            calculaJuros.Verify(r => r.RetornaCalculoJuros(valorInicial, meses), Times.Once);
        }
    }
}
