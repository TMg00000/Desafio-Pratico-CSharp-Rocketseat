using System.Security.Cryptography.X509Certificates;

namespace SextoDesafio;

public class GetDateTime
{
    
    public Dictionary<string, string> GetDate()
    {
        Console.WriteLine("Digite uma data e hora a ser formatada");

        Dictionary<string, string> date = new Dictionary<string, string>();
        int i = 0;

        while (i < 6)
        {
            
            var getDate = Console.ReadLine();
            switch (i)
            {
                case 0:
                    date.Add("Day", getDate);
                    Console.WriteLine("Mês");
                    break;
                case 1:
                    date.Add("Month", getDate);
                    Console.WriteLine("Ano");
                    break;
                case 2:
                    date.Add("Year", getDate);
                    Console.WriteLine("Hora");
                    break;
                case 3:
                    date.Add("Hour", getDate);
                    Console.WriteLine("Minuto");
                    break;
                case 4:
                    date.Add("Minute", getDate);
                    Console.WriteLine("Segundo");
                    break;
                case 5:
                    date.Add("Seconds", getDate);
                    break;
            }
            i++;
        }

        var formatDateTime = new FormatDateTime();

        formatDateTime.FormatDate(date["Day"],date["Month"], date["Year"], date["Hour"], date["Minute"], date["Seconds"]);

        return date;
    }
}
