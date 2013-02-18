using System;
using System.Globalization;

class SixAndAHalfHoursLater
{
    private const string DATE_FORMAT = "d.M.yyyy h:m:s";

    static void Main()
    {
        CultureInfo cultureInfo = new CultureInfo("bg-BG");

        Console.WriteLine("Enter date in format day.month.year hour:minute:seconds ");
        //string inputDate = Console.ReadLine();
        string inputDate = "11.6.2013 11:30:12";

        DateTime date = DateTime.ParseExact(inputDate,
            DATE_FORMAT, cultureInfo);

        date = date.AddHours(6.5);

        Console.WriteLine("{0} {1}", date.ToString(DATE_FORMAT),
            date.ToString("dddd", cultureInfo));
    }
}

