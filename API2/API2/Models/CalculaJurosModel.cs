using API2.DAL;
using API2.ICollections;

namespace API2.Models
{
    public class CalculaJurosModel : ICalculaJuros
    {
        private DataAccess? _dataAccess;
        private UtilitiesModel? _utilities;

        public double RetornaCalculoJuros(double valorInicial, int meses)
        {
            // instância objeto de DataAccess
            _dataAccess = new DataAccess();

            // instância objeto do Model Utilities
            _utilities = new UtilitiesModel();

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
