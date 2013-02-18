using System;

class BinaryRepresentation
{
    static void Main()
    {
        Console.Write("Number = ");
        short number = short.Parse(Console.ReadLine());

        Console.Write("{0} = ", number);
        for (int i = 15; i >= 0; i--)
        {
            if (((1 << i) & number) != 0)
            {
                Console.Write(1);
            }
            else
            {
                Console.Write(0);
            }

            if (i % 4 == 0 && i != 0)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}

