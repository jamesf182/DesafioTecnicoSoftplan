namespace API2.Models
{
    /// <summary>
    /// Classe com métodos de utilidade pública para o projeto
    /// </summary>
    public class UtilitiesModel
    {
        /// <summary>
        /// Trunca um valor com X casas decimais
        /// </summary>
        /// <param name="valor">Valor a ser truncado</param>
        /// <param name="qtdeCasasDecimais">Quantidade de casas decimais</param>
        /// <returns>Retornar o valor truncado com a quantidade de casas decimais solicitado</returns>
        /// <exception cref="SystemException"></exception>
        public double TruncaValorComXCasasDecimais(double valor, int qtdeCasasDecimais = 2)
        {
            if (qtdeCasasDecimais < 0)
            {
                throw new Exception("A quantidade de casas decimais deve ser maior ou igual a zero.");
            }

            // multiplica o valor por 10 elevado ao número de casas decimais para que as casas decimais façam parte do valor inteiro
            valor *= Math.Pow(10, qtdeCasasDecimais);

            // trunca o valor para perder as casas decimais restantes
            valor = Math.Truncate(valor);
            
            // divide o valor por 10 elevado ao número de casas decimais para que os dois últimos inteiros voltem a ser casas decimais
            valor /= Math.Pow(10, qtdeCasasDecimais);

            return valor;                      
        }
    }
}
