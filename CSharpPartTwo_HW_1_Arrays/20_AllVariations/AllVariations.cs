using System;
using System.Text;

class AllVariations
{
    private static StringBuilder result = new StringBuilder();

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[k];
        Variations(array, 0);

        Console.WriteLine(result);
    }

    private static void Variations(int[] array, int index)
    {
        if (index == array.Length)
        {
            AddVariationToResult(array);
            return;
        }

        for (int i = 1; i <= array.Length; i++)
        {
            array[index] = i;
            Variations(array, index + 1);
        }
    }

    private static void AddVariationToResult(int[] variation)
    {
        result.Append("{ ");
        foreach (var num in variation)
        {
            result.AppendFormat("{0} ", num);
        }
        result.AppendLine("}");
    }
}

