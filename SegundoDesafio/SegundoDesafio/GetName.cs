namespace SegundoDesafio;

public class GetName
{
    public (string firstName, string lastName) GetNameUsers()
    {
        Console.WriteLine("Preencha as informações a baixo e aperte ENTER para confirmar.");
  
        var firstNameUser = Console.ReadLine();
        Console.WriteLine("Nome:");

        Console.WriteLine("Sobrenome:");
        var lastNameUser = Console.ReadLine();

        return (firstNameUser, lastNameUser);
    }
}
