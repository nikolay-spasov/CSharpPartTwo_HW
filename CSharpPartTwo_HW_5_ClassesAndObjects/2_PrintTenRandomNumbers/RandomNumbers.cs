using System;

class RandomNumbers
{
    private const int MIN = 100;
    private const int MAX = 200;
    private const int COUNT = 10;

    private static Random rand;

    static void Main()
    {
        rand = new Random();

        for (int i = 0; i < COUNT; i++)
        {
            Console.WriteLine(rand.Next(MIN, MAX + 1));
        }
    }
}

