using System;
using System.Text;

class BinToHex
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string number = Console.ReadLine();

        string bin = number;

        StringBuilder builder = new StringBuilder();
        if (bin.Length % 4 != 0)
        {
            int remainder = bin.Length % 4;
            for (int i = 0; i < 4 - remainder; i++)
            {
                builder.Append("0");
            }
            for (int i = 0; i < bin.Length; i++)
            {
                builder.Append(bin[i]);
            }

            bin = builder.ToString();
        }

        Console.Write("{0} = ", number);
        for (int i = 0; i < bin.Length; i += 4)
        {
            string current = bin.Substring(i, 4);
            Console.Write(GetChar(current));
        }
        Console.WriteLine();
    }

    private static char GetChar(string quartet)
    {
        switch (quartet)
        {
            case "0000":
                return '0';
            case "0001":
                return '1';
            case "0010":
                return '2';
            case "0011":
                return '3';
            case "0100":
                return '4';
            case "0101":
                return '5';
            case "0110":
                return '6';
            case "0111":
                return '7';
            case "1000":
                return '8';
            case "1001":
                return '9';
            case "1010":
                return 'A';
            case "1011":
                return 'B';
            case "1100":
                return 'C';
            case "1101":
                return 'D';
            case "1110":
                return 'E';
            case "1111":
                return 'F';
        }

        return ' ';
    }
}

