using System;

class BiggestOfThreeIntegers
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());

        int max = GetMax(a, GetMax(b, c));

        Console.WriteLine("Max = {0}", max);
    }

    static int GetMax(int a, int b)
    {
        return Math.Max(a, b);
    }
}

