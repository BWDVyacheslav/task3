using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string dateString = "15.07.2023";
        string numberString = "123.45";
        string invalidNumber = "abc";
        string customDate = "2023-12-25 14:30:00";

        Console.WriteLine("ParseExact():");
        DateTime date1 = DateTime.ParseExact(dateString, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine(date1);

        Console.WriteLine("\nParse():");
        DateTime date2 = DateTime.Parse("2023-01-15");
        double number1 = double.Parse(numberString, CultureInfo.InvariantCulture);
        Console.WriteLine(date2);
        Console.WriteLine(number1);

        Console.WriteLine("\nTryParse():");
        bool success1 = int.TryParse(numberString, out int result1);
        bool success2 = int.TryParse(invalidNumber, out int result2);
        Console.WriteLine(success1 + " " + result1);
        Console.WriteLine(success2 + " " + result2);

        Console.WriteLine("\nTryParseExact():");
        bool success3 = DateTime.TryParseExact(customDate, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result3);
        bool success4 = DateTime.TryParseExact("invalid", "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result4);
        Console.WriteLine(success3 + " " + result3);
        Console.WriteLine(success4 + " " + result4);
    }
}