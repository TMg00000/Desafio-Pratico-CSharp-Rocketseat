namespace QuintoDesafio;
using System.Text.RegularExpressions;

public class BoardCondition
{
    public (bool boolValue, string confirmation) conditionRegex(string plate)
    {
        string pattern = @"^[A-Z]{3}\d{4}$";

        var regex = new Regex(pattern);

        string text;

        if (plate.Length == 7)
        {
            text = regex.IsMatch(plate) ? $"Placa: {plate}, Válida" : $"Placa: {plate}, Inválida";
            return (regex.IsMatch(plate), text);
        }
        else
        {
            text = regex.IsMatch(plate) ? $"Placa: {plate}, Válida" : $"Placa: {plate}, Inválida";
            return (regex.IsMatch(plate), text);
        }
    }
}
