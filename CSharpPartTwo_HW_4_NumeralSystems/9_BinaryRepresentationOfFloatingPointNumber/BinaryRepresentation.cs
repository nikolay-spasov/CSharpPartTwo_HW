using System;

class BinaryRepresentation
{
    static void Main()
    {
        float number = float.Parse(Console.ReadLine());

        byte[] bytes = BitConverter.GetBytes(number);

        Console.Write("sign: ");
        int bitCounter = 0;
        for (int i = bytes.Length - 1; i >= 0; i--)
        {
            for (int bit = 0; bit < 8; bit++)
            {
                if (((1 << (7 - bit)) & bytes[i]) != 0)
                {
                    Console.Write(1);
                }
                else
                {
                    Console.Write(0);
                }
                bitCounter++;

                if (bitCounter == 1)
                {
                    Console.Write(", exponent: ");
                }
                if (bitCounter == 9)
                {
                    Console.Write(", mantissa: ");
                }
            }
            
        }

        Console.WriteLine();
    }
}

