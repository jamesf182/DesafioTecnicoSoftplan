using API2.DAL;
using API2.Models;
using Microsoft.AspNetCore.Mvc;

namespace API2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private DataAccess? _dataAccess;
        private UtilitiesModel? _utilities;

        /// <summary>
        /// Calcula Juros
        /// </summary>
        /// <param name="valorInicial">Valor Inicial</param>
        /// <param name="meses">Quantidade de Meses</param>
        /// <returns>Retorna o cálculo dos juros</returns>
        [HttpGet]
        public double GetCalculaJuros(double valorInicial, int meses)
        {
            // instância objeto de DataAccess
            _dataAccess = new DataAccess();

            // instância objeto do Model Utilities
            _utilities = new UtilitiesModel();

            // seta url da API que será consultada
            string url = "api/TaxaJuros";

            try
            {
                // busca a taxa de juros
                double taxaJuros = _dataAccess.GetObject<double>(url);

                // calcula o valor final
                double valorFinal = valorInicial * Math.Pow((1 + taxaJuros), meses);

                // trunca o valor final com duas casas decimais
                valorFinal = _utilities.TruncaValorComXCasasDecimais(valorFinal, 2);

                return valorFinal;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
