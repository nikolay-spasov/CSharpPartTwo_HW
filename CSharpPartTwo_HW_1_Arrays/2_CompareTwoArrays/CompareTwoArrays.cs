using System;

class CompareTwoArrays
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the arrays.");
        int n = int.Parse(Console.ReadLine());

        int[] firstArray = new int[n];
        int[] secondArray = new int[n];

        Console.WriteLine("Enter the elements of the first array.");
        for (int i = 0; i < n; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the elements of the second array.");
        for (int i = 0; i < n; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            if (firstArray[i] > secondArray[i])
            {
                Console.WriteLine("{0} > {1}", firstArray[i], secondArray[i]);
            }
            else if (firstArray[i] < secondArray[i])
            {
                Console.WriteLine("{0} < {1}", firstArray[i], secondArray[i]);
            }
            else
            {
                Console.WriteLine("{0} = {1}", firstArray[i], secondArray[i]);
            }
        }
    }
}

