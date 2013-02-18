using System;

class LastDigitAsString
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(LastDigit(number));
    }

    static string LastDigit(int number)
    {
        string[] digits = 
        {
          "Zero", "One", "Two", "Three", "Four",
          "Five", "Six", "Seven", "Eight", "Nine" 
        };

        int lastDigit = number % 10;

        return digits[Math.Abs(lastDigit)];
    }
}

