namespace TerceiroDesafio;
using TerceiroDesafio.Operacoes;
public class Program
{
    static void Main()
    {
        var results = new Result().AllResult();

        var text =
            $"Soma: {results.adicao}\n" +
            $"Subtração: {results.sub}\n" +
            $"Divisão: {results.div}\n" +
            $"Multiplicação: {results.mult}\n" +
            $"Media: {results.media}";

        Console.WriteLine(text);
    }
}
