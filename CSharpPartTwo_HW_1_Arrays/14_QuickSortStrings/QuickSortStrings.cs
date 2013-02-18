using System;

class QuickSortStrings
{
    static Random rand;

    static void Main()
    {
        rand = new Random();

        string[] lines = GetArrayFromUser();
        Reshuffle(lines);

        Sort(lines, 0, lines.Length - 1);
        Console.WriteLine("=========== After Sort ==========");
        PrintArray(lines);
    }

    public static string[] GetArrayFromUser()
    {
        Console.Write("Enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());

        string[] result = new string[n];

        Console.WriteLine("Start entering strings.");
        for (int i = 0; i < n; i++)
        {
            result[i] = Console.ReadLine();
        }

        return result;
    }

    public static void Sort(string[] array, int lo, int hi)
    {
        if (hi <= lo)
        {
            return;
        }

        int j = Partition(array, lo, hi);
        Sort(array, lo, j - 1);
        Sort(array, j + 1, hi);
    }

    public static void PrintArray(string[] array)
    {
        foreach (string s in array)
        {
            Console.WriteLine(s);
        }
    }

    private static void Reshuffle(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int randIndex = rand.Next(0, array.Length);
            Exchange(array, i, randIndex);
        }
    }

    private static int Partition(string[] array, int lo, int hi)
    {
        int i = lo;
        int j = hi + 1;
        string v = array[lo];

        while (true)
        {
            while (string.Compare(array[++i], v) < 0)
            {
                if (i == hi)
                {
                    break;
                }
            }
            while (string.Compare(v, array[--j]) < 0)
            {
                if (j == lo)
                {
                    break;
                }
            }

            if (i >= j)
            {
                break;
            }

            Exchange(array, i, j);
        }

        Exchange(array, lo, j);
        return j;
    }

    private static void Exchange(string[] array, int a, int b)
    {
        string temp = array[a];
        array[a] = array[b];
        array[b] = temp;
    }
}

