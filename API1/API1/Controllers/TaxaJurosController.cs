using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API1.Controllers
{    
    [Route("api/[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        private const double TAXA_JUROS = 0.01;

        /// <summary>
        /// Retorna a taxa de juros
        /// </summary>
        /// <returns>Retorna a taxa de turos</returns>
        [HttpGet]
        public double GetTaxaJuros()
        {
            return TAXA_JUROS;
        }
    }
}
