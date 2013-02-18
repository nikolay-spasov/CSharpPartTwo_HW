using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter a number in binary format: ");
        string number = Console.ReadLine();

        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] != '0' && number[i] != '1')
            {
                Console.WriteLine("Error! Wrong bit sequence.");
                return;
            }
        }

        uint result = 0;
        uint powerOfTwo = 1;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            result += (uint.Parse(number[i].ToString()) * powerOfTwo);
            powerOfTwo <<= 1;
        }

        Console.WriteLine(result);
    }
}

