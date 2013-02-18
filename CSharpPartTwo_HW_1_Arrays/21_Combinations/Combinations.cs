using System;
using System.Text;

class Combinations
{
    private static StringBuilder result = new StringBuilder();

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[k];
        Combination(array, 0, 1, n);

        Console.Write(result);
    }

    static void Combination(int[] array, int index, int currentNumber, int n)
    {
        if (index == array.Length)
        {
            AddCombinationToResult(array);
            return;
        }
       
        for (int i = currentNumber; i <= n; i++)
        {
            array[index] = i;
            Combination(array, index + 1, i + 1, n);
        }
    }

    private static void AddCombinationToResult(int[] array)
    {
        result.Append("{ ");
        for (int i = 0; i < array.Length; i++)
        {
            result.AppendFormat("{0} ", array[i]);
        }
        result.AppendLine("}");
    }
}

