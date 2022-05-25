using API.Models;
using API2.DAL;

namespace API2.Models
{
    public class CalculaJurosModel : ICalculaJuros
    {
        private readonly DataAccess _dataAccess = new();
        private readonly UtilitiesModel _utilities = new();

        /// <summary>
        /// Calcula o valor final com juros referente a quantidade de meses
        /// </summary>
        /// <param name="valorInicial">Valor Inicial</param>
        /// <param name="meses">Quantidade de meses</param>
        /// <returns>Retona o valor com os juros calculado</returns>
        /// <exception cref="Exception"></exception>
        public double RetornaCalculoJuros(double valorInicial, int meses)
        {
            // seta url da API que será consultada
            string url = "api/TaxaJuros";

            try
            {
                // validações
                if (valorInicial <= 0)
                {
                    throw new Exception("Valor inicial deve ser maior que zero.");
                }

                if (meses <= 0)
                {
                    throw new Exception("O número de meses deve ser maior que zero.");
                }

                // busca a taxa de juros
                double taxaJuros = _dataAccess.GetObject<double>(url);

                // calcula o valor final
                double valorFinal = valorInicial * Math.Pow((1 + taxaJuros), meses);

                // trunca o valor final com duas casas decimais
                valorFinal = _utilities.TruncaValorComXCasasDecimais(valorFinal);

                return valorFinal;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
