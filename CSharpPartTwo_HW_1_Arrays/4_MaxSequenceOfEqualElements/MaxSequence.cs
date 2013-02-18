using System;

class MaxSequence
{
    static void Main()
    {
        //int[] numbers = { 2, 1, 1, 3, 3, 3, 3, 2, 2, 2, 2, 2 };

        int[] numbers = GetInput();

        int bestStart = 0;
        int bestLength = 1;

        int start = 0;
        int length = 1;

        for (int i = 1; i <= numbers.Length - 1; i++)
        {
            if (numbers[start] == numbers[i])
            {
                length++;
            }
            else
            {
                start += length;
                length = 1;
            }

            if (bestLength < length)
            {
                bestLength = length;
                bestStart = start;
            }
        }

        for (int i = bestStart; i <= bestStart + bestLength - 1; i++)
        {
            Console.Write("{0, 3}", numbers[i]);
        }
        Console.WriteLine();
    }

    static int[] GetInput()
    {
        Console.WriteLine("N = ");
        int n = int.Parse(Console.ReadLine());

        int[] result = new int[n];

        for (int i = 0; i < n; i++)
        {
            result[i] = int.Parse(Console.ReadLine());
        }

        return result;
    }
}

