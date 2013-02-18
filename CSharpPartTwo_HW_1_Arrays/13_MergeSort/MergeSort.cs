using System;
using System.Collections.Generic;

class MergeSort
{
    static void Main()
    {
        int[] numbers = GetArrayFromUser();
        int len = numbers.Length;
        Sort(numbers);
        Console.WriteLine("============ After Sort ================");
        PrintArray(numbers);
    }

    public static int[] GetArrayFromUser()
    {
        Console.Write("Enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] result = new int[n];
        Console.WriteLine("Start entering numbers.");
        for (int i = 0; i < n; i++)
        {
            result[i] = int.Parse(Console.ReadLine());
        }

        return result;
    }

    public static void PrintArray(int[] array)
    {
        foreach (var num in array)
        {
            Console.WriteLine(num);
        }
    }

    public static void Sort(int[] array)
    {
        int[] workArray = new int[array.Length];
        BottomUpMergeSort(array.Length, array, workArray);
    }

    private static void BottomUpMergeSort(int n, int[] a, int[] b)
    {
        for (int width = 1; width < n; width *= 2)
        {
            for (int i = 0; i < n; i += (2 * width))
            {
                Merge(a, i, Math.Min(i + width, n), Math.Min(i + 2 * width, n), b);
            }

            Array.Copy(b, a, n);
        }
    }

    private static void Merge(int[] a, int left, int right, int end, int[] b)
    {
        int i0 = left;
        int i1 = right;

        for (int j = left; j < end; j++)
        {
            if (i0 < right && (i1 >= end || a[i0] <= a[i1]))
            {
                b[j] = a[i0];
                i0++;
            }
            else
            {
                b[j] = a[i1];
                i1++;
            }
        }
    }
}

