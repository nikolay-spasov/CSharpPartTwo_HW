using System;

class SumOfANumberSequence
{
    static void Main()
    {
        Console.WriteLine("Enter the number sequence.");
        string line = Console.ReadLine();

        int sum = Sum(line);

        Console.WriteLine("string = \"{0}\" -> result = {1}", line, sum);
    }

    public static int Sum(string sequence)
    {
        int sum = 0;

        foreach (var s in sequence.Split(' '))
        {
            sum += int.Parse(s);
        }

        return sum;
    }
}

