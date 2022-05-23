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
        /// Taxa de Juros
        /// </summary>
        /// <returns>Retorna a Taxa de Juros</returns>
        [HttpGet]
        public double GetTaxaJuros()
        {
            return TAXA_JUROS;
        }
    }
}
