using System;

class MaxSumElements
{
    static int n;
    static int k;
    static int[] numbers;

    static void Main()
    {
        GetInput();

        Array.Sort(numbers);

        int sum = 0;
        for (int i = 0; i < k; i++)
        {
            Console.Write("{0} ", numbers[n - 1 - i]);
            sum += numbers[n - 1 - i];
        }

        Console.WriteLine("sum -> {0}", sum);
    }

    private static void GetInput()
    {
        Console.Write("N = ");
        n = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        k = int.Parse(Console.ReadLine());
        numbers = new int[n];

        if (k > n)
        {
            k = n;
        }

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
    }
}

