namespace QuartoDesafio;

public class Condicao
{
    public void stringVazia(string phrase)
    {

        while (phrase.Length == 0 || phrase == null)
        {
            Console.WriteLine("Você ainda não digitou nada.");
            phrase = Console.ReadLine().Replace(" ", string.Empty);
            continue;
        }

        Console.WriteLine($"A palavra ou frase digitada tem {phrase.Length} caracteres.");
    }

    public void continuar()
    {
        var CountWords = new CountWords();

        Console.WriteLine(" ");
        Console.WriteLine("Deseja Continuar ? [s]im ou [n]ão");

        if (Console.ReadLine().ToLower() == "s")
        {
            CountWords.CountWordsProMax();
        }
        else
        {
            Console.WriteLine(" ");
            Console.WriteLine("Obrigado por usar o programa.");
        }
    }
}
