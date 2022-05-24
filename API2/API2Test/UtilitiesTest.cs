using API2.Models;

namespace API2Test
{
    public class UtilitiesTest
    {
        private UtilitiesModel? _utilities;

        [Theory]
        [InlineData(100.1039, 2, 100.10)]
        [InlineData(100.9999999, 2, 100.99)]
        [InlineData(100.2555687, 3, 100.255)]
        [InlineData(100.38994759, 4, 100.3899)]
        [InlineData(100.8112423658, 5, 100.81124)]
        public void TruncaValor_Valida_Retorno(double valor, int qtdeCasasDecimais, double valorEsperado)
        {
            _utilities = new UtilitiesModel();

            // Act
            double valorTruncado = _utilities.TruncaValorComXCasasDecimais(valor, qtdeCasasDecimais);

            // Assert
            Assert.Equal(valorEsperado, valorTruncado);
        }

        [Fact]
        public void TruncaValor_QuandoChamado_RetornaDouble()
        {
            _utilities = new UtilitiesModel();

            // Arrange
            double valor = 100.8581;
            int qtdeCasasDecimais = 2;

            // Act            
            double calculaJuros = _utilities.TruncaValorComXCasasDecimais(valor, qtdeCasasDecimais);

            // Assert
            Assert.IsType<double>(calculaJuros);
        }
    }
}
