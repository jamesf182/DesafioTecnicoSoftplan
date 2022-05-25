using API1.Controllers;

namespace UnitTests.Tests
{
    public class TaxaJurosTest
    {
        private readonly TaxaJurosController _taxaJurosController = new();

        [Fact(DisplayName = "Valida o tipo de retorno como double")]
        public void TaxaJuros_QuandoChamado_RetornaDouble()
        {
            // Act            
            double taxaJuros = _taxaJurosController.GetTaxaJuros();

            // Assert
            Assert.IsType<double>(taxaJuros);
        }
    }
}
