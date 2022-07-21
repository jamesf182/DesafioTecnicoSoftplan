using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        //private readonly CalculaJurosModel _calculaJuros = new();

        private readonly ICalculaJuros _calculaJuros;

        public CalculaJurosController(ICalculaJuros calculaJuros)
        {
            _calculaJuros = calculaJuros;
        }

        /// <summary>
        /// Calcula o valor final com juros referente a quantidade de meses
        /// </summary>
        /// <param name="valorInicial">Valor inicial</param>
        /// <param name="meses">Número de meses</param>
        /// <returns>Retorna o valor com os juros calculado</returns>
        [HttpGet]
        public double GetCalculaJuros(double valorInicial, int meses)
        {
            return _calculaJuros.RetornaCalculoJuros(valorInicial, meses);
        }
    }
}
