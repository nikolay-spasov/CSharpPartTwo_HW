using System;

class LargestNumberLessOrEqualToK
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("Start filling the array. (each element on a separate line).");
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);

        if (k < numbers[0])
        {
            Console.WriteLine("No element less than or equal to {0}", k);
            return;
        }

        if (Array.BinarySearch(numbers, k) >= 0)
        {
            Console.WriteLine(k);
        }
        else
        {
            while (true)
            {
                if (Array.BinarySearch(numbers, --k) >= 0)
                {
                    Console.WriteLine(k);
                    return;
                }
            }
        }
    }
}
