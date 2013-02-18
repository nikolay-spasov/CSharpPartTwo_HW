using System;

class DecToHex
{
    private const int BASE = 16;

    static void Main()
    {
        Console.Write("Enter a number in decimal system: ");
        uint number = uint.Parse(Console.ReadLine());

        char[] result = new char[32];

        uint temp = number;

        int index = 31;
        while (temp > 0)
        {
            uint remainder = temp % BASE;

            switch (remainder)
            {
                case 10:
                    result[index] = 'A';
                    break;
                case 11:
                    result[index] = 'B';
                    break;
                case 12:
                    result[index] = 'C';
                    break;
                case 13:
                    result[index] = 'D';
                    break;
                case 14:
                    result[index] = 'E';
                    break;
                case 15:
                    result[index] = 'F';
                    break;
                default:
                    result[index] = char.Parse(remainder.ToString());
                    break;
            }

            temp /= BASE;
            index--;
        }
        Console.Write("{0} = ", number);
        PrintNumberInHex(result);
    }

    static void PrintNumberInHex(char[] result)
    {
        bool leadingZero = true;
        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] != '\0' && leadingZero)
            {
                leadingZero = false;
            }
            if (result[i] == 0 && leadingZero)
            {
                continue;
            }
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}

