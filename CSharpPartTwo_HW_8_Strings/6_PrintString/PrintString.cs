using System;

class PrintString
{
    private const int MAX_LENGTH = 20;

    static void Main()
    {
        Console.WriteLine("Enter string (max length = {0}) ", MAX_LENGTH);
        string str = Console.ReadLine();

        if (str.Length > MAX_LENGTH)
        {
            Console.WriteLine("String is too long (max Length = {0})!", MAX_LENGTH);
            return;
        }

        str += new String('*', MAX_LENGTH - str.Length);

        Console.WriteLine(str);
    }
}

