using System;
using System.Text;

class AllPermutations
{
    private static StringBuilder result = new StringBuilder();

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = GetNumbers(n);

        Permutate(numbers, 0, n - 1);

        Console.WriteLine(result);
    }

    private static void Permutate(int[] array, int start, int end)
    {
        if (start == end)
        {
            result.Append("{ ");
            for (int i = 0; i <= end; i++)
            {
                result.AppendFormat("{0} ", array[i]);
            }
            result.Append("} ");

            return;
        }
        
        for (int i = start; i <= end; i++)
        {
            Swap(ref array[i], ref array[start]);
            Permutate(array, start + 1, end);
            Swap(ref array[i], ref array[start]);
        }
    }

    private static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    private static int[] GetNumbers(int n)
    {
        int[] result = new int[n];
        for (int i = 0; i < n; i++)
        {
            result[i] = i + 1;
        }

        return result;
    }
}

