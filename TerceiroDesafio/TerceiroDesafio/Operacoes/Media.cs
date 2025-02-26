namespace TerceiroDesafio.Operacoes;

public class Media
{
    public double ResultMedia(double numOne, double numTwo)
    {
        var soma = numOne + numTwo;

        List<double> list = new List<double> { numOne, numTwo };
        var divisor = list.Count;

        var calc = soma / divisor;
        return calc;
    }
}
