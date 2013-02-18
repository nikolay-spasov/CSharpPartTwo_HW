using System;

class SortStringsByLength
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Start filling the array (each element of a separate line).");
        string[] array = new string[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = Console.ReadLine();
        }

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i].Length > array[j].Length)
                {
                    string temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }

        foreach (var s in array)
        {
            Console.WriteLine(s);
        }
    }
}

