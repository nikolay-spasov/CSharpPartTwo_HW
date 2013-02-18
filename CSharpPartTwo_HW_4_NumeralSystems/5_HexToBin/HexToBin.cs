using System;

class HexToBin
{
    static void Main()
    {
        Console.Write("Enter a number in Hex: ");
        string hex = Console.ReadLine();

        string[] quartet = new string[]
        {
            "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111",
            "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111"
        };

        Console.Write("{0} = ", hex);
        for (int i = 0; i < hex.Length; i++)
        {
            char ch = hex[i];

            int index = 0;
            switch (ch)
            {
                case 'A':
                    index = 10;
                    break;
                case 'B':
                    index = 11;
                    break;
                case 'C':
                    index = 12;
                    break;
                case 'D':
                    index = 13;
                    break;
                case 'E':
                    index = 14;
                    break;
                case 'F':
                    index = 15;
                    break;
                default:
                    index = ch - '0';
                    break;
            }

            Console.Write(quartet[index]);
        }
        Console.WriteLine();
    }
}

