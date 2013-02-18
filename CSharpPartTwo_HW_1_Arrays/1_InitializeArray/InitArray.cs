using System;

class InitArray
{
    static void Main()
    {
        int[] numbers = new int[20];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i * 5;
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("{0, 3}", numbers[i]);
        }
        Console.WriteLine();
    }
}

