using System;

class PrintWords
{
    static void Main()
    {
        // string str = "word letter sentence zebra guitar";

        Console.WriteLine("Enter some words separated by space: ");
        string str = Console.ReadLine();

        string[] words = str.Split(' ');

        Array.Sort(words);

        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}

