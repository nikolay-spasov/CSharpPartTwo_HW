using System;

class MaxIncreasingSequence
{
    static void Main()
    {
        //int[] numbers = { 3, 2, 3, 4, 8, 9, 2, 3, 4, 5 };
        //int[] numbers = { 5, 4, 3, 2, 1 };
        int[] numbers = GetInput();

        int bestStart = 0;
        int bestLength = 1;

        int start = 0;
        int length = 1;
        //int current = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] < numbers[i + 1])
            {
                length++;
            }
            else
            {
                start += length;
                length = 1;
            }

            if (length > bestLength)
            {
                bestLength = length;
                bestStart = start;
            }
        }

        for (int i = bestStart; i < bestStart + bestLength; i++)
        {
            Console.Write("{0, 3}", numbers[i]);
        }
        Console.WriteLine();
    }

    static int[] GetInput()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        int[] result = new int[n];

        for (int i = 0; i < n; i++)
        {
            result[i] = int.Parse(Console.ReadLine());
        }

        return result;
    }
}

