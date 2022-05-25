using API2.Models;

namespace API2Test.Tests
{
    public class UtilitiesTest
    {
        private readonly UtilitiesModel _utilitiesModel = new();

        [Theory(DisplayName = "Trunca o valor com X casas decimais")]
        [InlineData(100.5148, 0, 100)]
        [InlineData(100.1039, 2, 100.10)]
        [InlineData(100.9999999, 2, 100.99)]
        [InlineData(-100.2555687, 3, -100.255)]
        [InlineData(100.38994759, 4, 100.3899)]
        [InlineData(-100.8112423658, 5, -100.81124)]
        public void TruncaValor_Valida_Retorno(double valor, int qtdeCasasDecimais, double valorEsperado)
        {
            // Act
            double valorTruncado = _utilitiesModel.TruncaValorComXCasasDecimais(valor, qtdeCasasDecimais);

            // Assert
            Assert.Equal(valorEsperado, valorTruncado);
        }

        [Fact(DisplayName = "Valida o tipo de retorno como double")]
        public void TruncaValor_QuandoChamado_RetornaDouble()
        {
            // Arrange
            double valor = 100.8581;
            int qtdeCasasDecimais = 2;

            // Act            
            double calculaJuros = _utilitiesModel.TruncaValorComXCasasDecimais(valor, qtdeCasasDecimais);

            // Assert
            Assert.IsType<double>(calculaJuros);
        }
    }
}
