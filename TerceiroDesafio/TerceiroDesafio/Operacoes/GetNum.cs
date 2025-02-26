using System.Globalization;

namespace TerceiroDesafio.Operacoes;

public class GetNum
{
    public (double numOne, double numTwo) GetNumUsers()
    {   
        double numOneConverted;
        double numTwoConverted;

        Console.WriteLine("Digite o primeiro número: ");
        var numOne = Console.ReadLine().Replace(',', '.');
        while (!double.TryParse(numOne, NumberStyles.Any, CultureInfo.InvariantCulture, out numOneConverted))
        {
            Console.WriteLine("Digite um número válido");
            numOne = Console.ReadLine().Replace(',', '.');
        }

        Console.WriteLine("Digite o segundo número: ");
        var numTwo = Console.ReadLine().Replace(',', '.');
        while (!double.TryParse(numTwo, NumberStyles.Any, CultureInfo.InvariantCulture, out numTwoConverted))
        {
            Console.WriteLine("Digite um número válido");
            numTwo = Console.ReadLine().Replace(',', '.');
        }

        return (numOneConverted, numTwoConverted);
    }
}
