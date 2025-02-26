namespace SegundoDesafio;

public class FormatText
{
    static void Main()
    {
        var getNameUser = new GetName();
        var nameUser = getNameUser.GetNameUsers();

        string text = $"Olá, {nameUser.firstName.Trim()} {nameUser.lastName.Trim()}.";

        Console.WriteLine(text);
    }
}