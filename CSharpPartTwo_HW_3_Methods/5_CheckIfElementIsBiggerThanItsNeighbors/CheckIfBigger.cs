using System;

class CheckIfBigger
{
    static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        Console.Write("Enter the index that you want to check: ");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine("Start entering numbers (each on a separate line): ");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        bool result = BiggerThanItsNeighbors(index, numbers);

        if (result)
        {
            Console.WriteLine("Element at position {0} is bigger than its neighbors.",
                index, result);
        }
        else
        {
            Console.WriteLine("Element at position {0} is NOT bigger than its neighbors.",
                index);
        }
    }

    static bool BiggerThanItsNeighbors(int index, int[] array)
    {
        int left = int.MinValue;
        int current = array[index];
        int right = int.MinValue;

        if (index - 1 >= 0)
        {
            left = array[index - 1];
        }
        if (index + 1 < array.Length)
        {
            right = array[index + 1];
        }

        if (current > left && current > right)
        {
            return true;
        }

        return false;
    }
}

