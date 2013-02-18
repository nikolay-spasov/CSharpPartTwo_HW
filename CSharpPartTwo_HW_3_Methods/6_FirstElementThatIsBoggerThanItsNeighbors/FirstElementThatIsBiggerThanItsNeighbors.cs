using System;

class FirstElementThatIsBiggerThanItsNeighbors
{
    static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        Console.WriteLine("Start entering numbers (each on a separate line): ");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int index = FindElementThatIsBiggerThanItsNeighbors(numbers);

        if (index == -1)
        {
            Console.WriteLine("No such element exists!");
        }
        else
        {
            Console.WriteLine("Element found at position {0}", index);
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

    static int FindElementThatIsBiggerThanItsNeighbors(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (BiggerThanItsNeighbors(i, array))
            {
                return i;
            }
        }

        return -1;
    }
}

