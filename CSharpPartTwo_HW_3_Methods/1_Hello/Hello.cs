using System;

class Hello
{
    static void Main()
    {
        SayHello();
    }

    static void SayHello()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Hello, {0}!", name);
    }
}

