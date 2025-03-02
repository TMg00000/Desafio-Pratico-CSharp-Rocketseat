namespace SextoDesafio;

public class FormatDateTime
{
    public void FormatDate(string day, string month, string years, string hour, string minutes, string seconds)
    {
        var date = new DateTime(int.Parse(years), int.Parse(month), int.Parse(day), int.Parse(hour), int.Parse(minutes), int.Parse(seconds));

        Console.WriteLine($"Data formatada: {date.ToString("dddd, dd/MM/yyyy HH:mm:ss")}");
    }
}
