using System;

class CountElementAppearences
{
    static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        Console.WriteLine("Start entering the elements of the array (each on a separate line)");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter the element you are looking for: ");
        int key = int.Parse(Console.ReadLine());

        int count = CountElementAppereances(key, numbers);

        Console.WriteLine("{0} appears {1} times.", key, count);
    }

    static int CountElementAppereances(int number, int[] array)
    {
        int result = 0;
        foreach (int n in array)
        {
            if (n == number)
            {
                result++;
            }
        }

        return result;
    }
}

