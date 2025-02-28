using QuintoDesafio;

namespace QuintoDesaio;

public class Program
{
    public static void Main()
    {
        var getPlate = new GetVehicleLicensePlate();
        var value = getPlate.returnQueryResult();

        Console.WriteLine(value);
    
    }
}