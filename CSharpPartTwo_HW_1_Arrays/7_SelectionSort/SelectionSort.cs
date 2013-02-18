using System;

class SelectionSort
{
    static void Main()
    {
        int n;
        int[] numbers = GetInputArray(out n);

        for (int i = 0; i < n; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (numbers[j] < numbers[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = numbers[i];
            numbers[i] = numbers[minIndex];
            numbers[minIndex] = temp;
        }

        PrintArray(numbers, n);
    }

    static int[] GetInputArray(out int n)
    {
        Console.Write("N = ");
        n = int.Parse(Console.ReadLine());
        int[] result = new int[n];

        for (int i = 0; i < n; i++)
        {
            result[i] = int.Parse(Console.ReadLine());
        }

        return result;
    }

    static void PrintArray(int[] array, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0, 3}", array[i]);
        }
        Console.WriteLine();
    }
}

