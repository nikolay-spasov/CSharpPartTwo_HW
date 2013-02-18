using System;
using System.Collections.Generic;

class MostFrequentNumber
{
    static void Main()
    {
        //int[] numbers = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        Console.WriteLine("Enter the length ot the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        Console.WriteLine("Start entering the numbers.");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Dictionary<int, int> counts = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            if (!counts.ContainsKey(numbers[i]))
            {
                counts.Add(numbers[i], 1);
            }
            else
            {
                counts[numbers[i]]++;                
            }
        }

        int bestCount = 0;
        int bestKey = 0;
        foreach (var key in counts.Keys)
        {
            if (counts[key] > bestCount)
            {
                bestCount = counts[key];
                bestKey = key;
            }
        }

        Console.WriteLine("{0} ({1} times)", bestKey, counts[bestKey]);

        // Another Solution ===========================================
        //int bestCount = 0;
        //int bestNumber = 0;

        //for (int i = 0; i < n; i++)
        //{
        //    int count = 0;
        //    int number = numbers[i];
        //    for (int j = 0; j < n; j++)
        //    {
        //        if (numbers[i] == numbers[j])
        //        {
        //            count++;
        //            number = numbers[i];
        //        }

        //        if (bestCount < count)
        //        {
        //            bestCount = count;
        //            bestNumber = number;
        //        }
        //    }
        //}

        //Console.WriteLine("{0} ({1} times)", bestNumber, bestCount);
    }
}

