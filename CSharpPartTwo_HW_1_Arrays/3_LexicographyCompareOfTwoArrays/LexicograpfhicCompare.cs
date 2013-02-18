using System;

class LexicograpfhicCompare
{
    static int n;
    static char[] firstArray;
    static char[] secondArray;

    static void Main()
    {
        GetInput();

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

    static void GetInput()
    {
        Console.Write("N = ");
        n = int.Parse(Console.ReadLine());

        firstArray = new char[n];
        secondArray = new char[n];

        Console.WriteLine("First array");
        Console.WriteLine("One character at a line");
        for (int i = 0; i < n; i++)
        {
            firstArray[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine("Second array");
        for (int i = 0; i < n; i++)
        {
            secondArray[i] = char.Parse(Console.ReadLine());
        }
    }
}

