using System;

class PrintNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("{0,15}", number);
        Console.WriteLine("{0,15:X}", number);
        Console.WriteLine("{0,15:P}", number);
        Console.WriteLine("{0,15:e}", number);
    }
}

