namespace API2.Models
{
    public class UtilitiesModel
    {
        public double TruncaValorComXCasasDecimais(double valor, int qtdeCasasDecimais)
        {            
            // multiplica o valor por 10 elevado ao número de casas decimais para que as casas decimais façam parte do valor inteiro
            valor *= Math.Pow(10, qtdeCasasDecimais);

            // trunca o valor para perder as casas decimais restantes
            valor = Math.Truncate(valor);

            // divide o valor por 10 elevado ao número de casas decimais para que os dois últimos inteiros voltem a ser casas decimais
            if(valor < 0)
            {
                throw new ArgumentException("Valor menor que zero.");
            }
            valor /= Math.Pow(10, qtdeCasasDecimais);

            return valor;                      
        }
    }
}
