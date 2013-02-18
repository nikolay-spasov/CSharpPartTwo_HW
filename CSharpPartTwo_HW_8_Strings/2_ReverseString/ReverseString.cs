using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        string str = Console.ReadLine();

        StringBuilder builder = new StringBuilder();

        for (int i = str.Length - 1; i >= 0; i--)
        {
            builder.Append(str[i]);
        }

        Console.WriteLine("{0} -> {1}", str, builder);
    }
}

