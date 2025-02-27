using System.Diagnostics;

namespace QuartoDesafio;

public class CountWords
{
    public static string CountWordsProMax()
    {
        var condicao = new Condicao();

        Console.WriteLine("Digite uma palvra ou uma frase e descubra quantos caracteres ela tem: ");
        var phrase = Console.ReadLine().Replace(" ", string.Empty);
        condicao.stringVazia(phrase);

        Console.WriteLine(" ");
        condicao.continuar();

        return phrase;        
    }

}