using System;

class LeapYear
{
    static void Main()
    {
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("{0} is a leap year.", year);
        }
        else
        {
            Console.WriteLine("{0} is not a leap year.", year);
        }
    }
}

