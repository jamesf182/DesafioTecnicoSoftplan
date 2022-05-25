using API2.DAL;
using API2.ICollections;
using API2.Models;
using Microsoft.AspNetCore.Mvc;

namespace API2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private readonly CalculaJurosModel _calculaJurosModel = new();

        /// <summary>
        /// Calcula o valor acrescido de juros com base no período (meses)
        /// </summary>
        /// <param name="valorInicial">Valor inicial</param>
        /// <param name="meses">Número de meses</param>
        /// <returns>Retorna o valor calculado</returns>
        [HttpGet]
        public double GetCalculaJuros(double valorInicial, int meses)
        {
            return _calculaJurosModel.RetornaCalculoJuros(valorInicial, meses);
        }
    }
}
