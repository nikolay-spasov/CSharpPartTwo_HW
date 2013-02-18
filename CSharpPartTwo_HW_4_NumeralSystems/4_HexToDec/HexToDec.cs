using System;

class HexToDec
{
    static void Main()
    {
        Console.Write("Enter a number in a Hex format: ");
        string number = Console.ReadLine();

        uint result = 0;
        uint powerOfBase = 1;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            uint temp = 0;
            switch (number[i])
            {
                case 'A':
                    temp = 10;
                    break;
                case 'B':
                    temp = 11;
                    break;
                case 'C':
                    temp = 12;
                    break;
                case 'D':
                    temp = 13;
                    break;
                case 'E':
                    temp = 14;
                    break;
                case 'F':
                    temp = 15;
                    break;
                default:
                    temp = uint.Parse(number[i].ToString());
                    break;
            }

            result += (temp * powerOfBase);

            powerOfBase <<= 4;
        }

        Console.Write("{0} = ", number);
        Console.WriteLine(result);
    }
}

