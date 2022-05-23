using API2.Controllers;

namespace API2Test
{
    public class CalculaJurosTest
    {
        private CalculaJurosController? _calculaJurosController;
        
        [Fact]
        public void Calcular_QuandoChamado_RetornaDouble()
        {
            _calculaJurosController = new CalculaJurosController();

            // Arrange
            double valorInicial = 100;
            int meses = 2;

            // Act            
            double calculaJuros = _calculaJurosController.GetCalculaJuros(valorInicial, meses);

            // Assert
            Assert.IsType<double>(calculaJuros);
        }

        [Theory]
        [InlineData(100, 2, 102.01)]
        [InlineData(100, 3, 103.03)]
        [InlineData(100, 5, 105.10)]
        [InlineData(105, 2, 107.11)]
        [InlineData(105, 3, 108.18)]
        public void Calcular_Juros_RetornaDoubleTheory(double valorInicial, int meses, double valorEsperado)
        {
            _calculaJurosController = new CalculaJurosController();

            // Act
            double calculaJuros = _calculaJurosController.GetCalculaJuros(valorInicial, meses);

            // Assert
            Assert.Equal(valorEsperado, calculaJuros);
        }
    }
}
