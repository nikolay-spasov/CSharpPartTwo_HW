using System;

class ConverString
{
    static void Main()
    {
        string str = Console.ReadLine();

        foreach (char ch in str)
        {
            Console.Write("\\u{0:x4}", (ushort)ch);
        }
        Console.WriteLine();
    }
}

