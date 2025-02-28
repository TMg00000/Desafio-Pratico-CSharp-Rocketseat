namespace QuintoDesafio;

public class GetVehicleLicensePlate
{
    public string GetLicensePlate()
    {
        Console.WriteLine("Consultar placa do veículo Ex: ABC1234 ");
        string licensePlate = Console.ReadLine().ToUpper();

        return licensePlate;
    }

    public string returnQueryResult()
    {

        var boardCondition = new BoardCondition().conditionRegex(GetLicensePlate());

        var text = boardCondition.confirmation;

        while (!boardCondition.boolValue)
        {
            Console.WriteLine($"{boardCondition.confirmation}, digite novamente");
            boardCondition = new BoardCondition().conditionRegex(GetLicensePlate());
            text = boardCondition.confirmation;
            if (boardCondition.boolValue)
            {
                return text;
            }
            else
            {
                continue;
            }
        }

        return text;
    }
}
