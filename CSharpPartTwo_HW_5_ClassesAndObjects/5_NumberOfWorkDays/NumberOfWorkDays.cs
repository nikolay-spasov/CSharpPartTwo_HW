using System;
using System.Linq;

class NumberOfWorkDays
{
    static DateTime[] holidays = new DateTime[5];

    static void Main()
    {
        holidays[0] = new DateTime(2013, 3, 3);
        holidays[1] = new DateTime(2013, 9, 22);
        holidays[2] = new DateTime(2013, 12, 25);
        holidays[3] = new DateTime(2013, 1, 1);
        holidays[4] = new DateTime(2013, 9, 6);

        Console.Write("Enter the end date. [YYYY MM DD]: ");
        DateTime endDate = DateTime.Parse(Console.ReadLine());

        int workDays = CalculateWorkDays(endDate);
        Console.WriteLine("There are {0} workdays in this period.", workDays);
    }

    public static int CalculateWorkDays(DateTime endDate)
    {
        DateTime now = DateTime.Now;
        int result = 0;
        while (now.Date <= endDate.Date)
        {
            if (now.DayOfWeek != DayOfWeek.Saturday && now.DayOfWeek != DayOfWeek.Sunday &&
                !holidays.Contains<DateTime>(now.Date))
            {
                result++;
            }
            now = now.AddDays(1);
        }

        return result;
    }
}

