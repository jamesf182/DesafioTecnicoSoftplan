using API1.Controllers;

namespace API1Test
{
    public class TaxaJurosTest
    {
        TaxaJurosController _taxaJurosController = new TaxaJurosController();

        [Fact]
        public void TaxaJuros_QuandoChamado_RetornaDouble()
        {
            // Act            
            double taxaJuros = _taxaJurosController.GetTaxaJuros();

            // Assert
            Assert.IsType<double>(taxaJuros);
        }
    }
}
