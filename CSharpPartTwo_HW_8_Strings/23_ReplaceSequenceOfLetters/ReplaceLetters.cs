using System;
using System.Text;

class ReplaceLetters
{
    static void Main()
    {
        string str = Console.ReadLine();

        StringBuilder builder = new StringBuilder();

        char current = str[0];
        builder.Append(current);
        for (int i = 1; i < str.Length; i++)
        {
            if (str[i] != current)
            {
                current = str[i];
                builder.Append(current);
            }
        }

        Console.WriteLine(builder);
    }
}

