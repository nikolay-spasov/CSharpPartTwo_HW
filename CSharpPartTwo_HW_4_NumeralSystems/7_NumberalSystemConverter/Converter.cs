using System;
using System.Text;

class Converter
{
    static void Main()
    {
        Console.Write("Enter the numeral system of the input number: ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Enter the numberal system in which you want to convert: ");
        int d = int.Parse(Console.ReadLine());

        Console.Write("Enter number in base{0}: ", s);
        string inputNumber = Console.ReadLine();

        int dec = ConvertToDecimal(inputNumber, s);
        string numberInBaseD = ConvertFromDecimal(dec, d);

        Console.WriteLine("{0} base{1} = {2} base{3}", 
            inputNumber, s, numberInBaseD, d);
    }

    private static int ConvertToDecimal(string number, int fromBase)
    {
        int result = 0;
        int powerOfBase = 1;

        for (int i = number.Length - 1; i >= 0; i-- )
        {
            int n = GetCharValue(number[i]) * powerOfBase;

            powerOfBase *= fromBase;

            result += n;
        }

        return result;
    }

    private static string ConvertFromDecimal(int number, int toBase)
    {
        StringBuilder result = new StringBuilder();

        while (number > 0)
        {
            int mod = number % toBase;
            number /= toBase;

            result.Insert(0, GetCharFromValue(mod));
        }

        return result.ToString();
    }

    private static int GetCharValue(char ch)
    {
        switch (ch)
        {
            case 'A':
                return 10;
            case 'B':
                return 11;
            case 'C':
                return 12;
            case 'D':
                return 13;
            case 'E':
                return 14;
            case 'F':
                return 15;
            default:
                int val = ch - '0';
                if (val > 15 || val < 0)
                {
                    throw new ArgumentOutOfRangeException(string.Format(
                        "Argument must be in range [A, F] U [0, 9]. Current value: {0}.", ch));
                }
                return val;
        }
    }

    private static char GetCharFromValue(int val)
    {
        switch (val)
        {
            case 10:
                return 'A';
            case 11:
                return 'B';
            case 12:
                return 'C';
            case 13:
                return 'D';
            case 14:
                return 'E';
            case 15:
                return 'F';
            default:
                char ch = (char)val;
                ch += '0';
                if (val < 0 || val > 15)
                {
                    throw new ArgumentOutOfRangeException(string.Format(
                        "Argument must be in range [0, 15]. Current value {0}.", val));
                }
                return ch;
        }
    }
}