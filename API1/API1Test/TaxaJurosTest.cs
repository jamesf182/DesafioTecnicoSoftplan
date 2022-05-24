﻿using API1.Controllers;

namespace API1Test
{
    public class TaxaJurosTest
    {
        TaxaJurosController? _taxaJurosController;

        [Fact]
        public void TaxaJuros_QuandoChamado_RetornaDouble()
        {
            _taxaJurosController = new TaxaJurosController();
            
            // Act            
            double taxaJuros = _taxaJurosController.GetTaxaJuros();

            // Assert
            Assert.IsType<double>(taxaJuros);
        }
    }
}
