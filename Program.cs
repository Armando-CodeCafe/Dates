using System.Globalization;

namespace Dates;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // string date = "15/01/2002";
        // string format = "dd/MM/yyyy";
        // //Date time
        // DateTime dateTime = DateTime.ParseExact(date, format, CultureInfo.CurrentCulture);
        // Console.WriteLine(dateTime.ToString(format));




        string formaat = "dd/MM/yyyy";
        DateTime before = DateTime.Now;
        Console.WriteLine("Druk op enter om de timer te stoppen");
        Console.ReadLine();
        DateTime after = DateTime.Now;
        TimeSpan time = after - before;
        Console.WriteLine($"Je hebt {time.Seconds} aantal secondes gewacht");
        //https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings

        Console.WriteLine($"Vul je verjaardag in ({formaat})");
        string birthday = Console.ReadLine();
        DateTime birthdayDate = DateTime.ParseExact(birthday, formaat, CultureInfo.CurrentCulture);
        DateTime today = DateTime.Now;
        Console.WriteLine($"Het is vandaag {today.ToString(formaat)}");
        Console.WriteLine($"Je bent jarig op {birthdayDate.ToString(formaat)}");
        TimeSpan timeSpan = today - birthdayDate;
        int age;
        age = (int)(timeSpan.Days / 365.25f);
        Console.WriteLine($"Je bent dus {age} jaar oud");



    }
}

class Person
{
    public string Name { get; set; }
    public DateTime BirthDay { get; set; }
    //https://www.w3schools.com/csharp/csharp_datedatetime.asp
}