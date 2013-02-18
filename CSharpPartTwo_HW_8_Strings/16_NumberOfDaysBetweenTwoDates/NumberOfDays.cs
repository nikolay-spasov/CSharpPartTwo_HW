using System;
using System.Globalization;

class NumberOfDays
{
    private const string DATE_FORMAT = "d.m.yyyy";

    static void Main()
    {
        Console.WriteLine("Format {0}", DATE_FORMAT);
        Console.Write("Enter the first date: ");
        DateTime first = DateTime.ParseExact(Console.ReadLine(), DATE_FORMAT, 
            CultureInfo.InvariantCulture);

        Console.Write("Enter the second date: ");
        DateTime second = DateTime.ParseExact(Console.ReadLine(), DATE_FORMAT, 
            CultureInfo.InvariantCulture);

        Console.WriteLine("Distance: {0} days.", 
            Math.Abs((first - second).TotalDays));

    }
}

