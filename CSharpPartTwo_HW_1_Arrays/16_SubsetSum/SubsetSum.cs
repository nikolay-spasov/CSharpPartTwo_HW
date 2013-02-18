using System;
using System.Collections.Generic;

class SubsetSum
{
    //static int[] arr = { 2, 1, 2, 4, 3, 5, 2, 6 };
    ////static int[] arr = { 2, 1, 3, 1000};
    //static int S = 14;

    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Sum = ");
        int S = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Enter the elements of the array (each on separate line):");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        // If the Sum is an element of the array find it and we are done
        foreach (var i in arr)
        {
            if (i == S)
            {
                Console.WriteLine("Yes");
                return;
            }
        }

        HashSet<int> posSums = new HashSet<int>();
        posSums.Add(arr[0]);

        for (int i = 1; i < arr.Length; i++)
        {
            HashSet<int> sums = new HashSet<int>();
            foreach (var sum in posSums)
            {
                int currentSum = sum + arr[i];
                if (currentSum == S)
                {
                    Console.WriteLine("Yes");
                    return;
                }
                sums.Add(currentSum);
            }

            posSums.Add(arr[i]);
            posSums.UnionWith(sums);
        }

        Console.WriteLine("No");
    }
}

