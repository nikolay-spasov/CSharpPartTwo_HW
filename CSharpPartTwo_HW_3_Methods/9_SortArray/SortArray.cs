using System;

class SortArray
{
    static void Main()
    {
        int[] array = { 1, 5, 2, 20, 5, 13 };

        Console.WriteLine("Descending");
        Sort(array, false);
        PrintArray(array);
        Console.WriteLine("Ascending");
        Sort(array, true);
        PrintArray(array);
    }

    public static void PrintArray(int[] array)
    {
        foreach (var num in array)
        {
            Console.WriteLine(num);
        }
    }

    private static int MaximalElementInPortion(int start, int[] array)
    {
        int maxIndex = start;

        for (int i = start + 1; i < array.Length; i++)
        {
            if (array[maxIndex] < array[i])
            {
                maxIndex = i;
            }
        }

        return maxIndex;
    }

    public static void Sort(int[] array, bool ascending)
    {
        if (ascending)
        {
            SortAscending(array);
        }
        else
        {
            SortDescending(array);
        }
    }

    private static void SortDescending(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int maxElementIndex = MaximalElementInPortion(i, array);
            int temp = array[maxElementIndex];
            array[maxElementIndex] = array[i];
            array[i] = temp;
        }
    }

    private static void SortAscending(int[] array)
    {
        SortDescending(array);
        Array.Reverse(array);
    }
}

