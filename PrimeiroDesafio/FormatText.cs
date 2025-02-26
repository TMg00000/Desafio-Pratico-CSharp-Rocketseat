namespace PrimeiroDesafio;

public class FormatText
{
    static void Main()
    {
        var getNameUser = new GetName();
        var nameUser = getNameUser.GetNameUsers();

        string text = $"Olá, {nameUser.Trim()}, Seja muito bem-vindo(a)!";

        Console.WriteLine(text);
    }
}