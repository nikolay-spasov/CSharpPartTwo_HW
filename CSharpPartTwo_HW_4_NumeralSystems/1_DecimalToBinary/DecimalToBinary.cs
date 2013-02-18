using System;
using System.Text;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter number in decimal system: ");
        uint number = uint.Parse(Console.ReadLine());

        uint[] result = new uint[32];

        uint temp = number;

        int index = 31;
        while (temp > 0)
        {
            result[index--] = temp % 2;
            temp >>= 1;
        }

        Console.Write("{0} = ", number);
        PrintResult(result);
    }

    public static void PrintResult(uint[] decimalNumber)
    {
        bool leadingZero = true;
        for (int i = 0; i < decimalNumber.Length; i++)
        {
            if (decimalNumber[i] != 0 && leadingZero)
            {
                leadingZero = false;
            }
            if (decimalNumber[i] == 0 && leadingZero)
            {
                continue;
            }
            Console.Write(decimalNumber[i]);
        }
        Console.WriteLine();
    }
}

