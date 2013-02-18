using System;

class Dictionary
{
    static void Main()
    {
        string[] dictionary = 
        {
            ".NET - platform for applications from Microsoft",
            "CLR - managed execution environment for .NET",
            "namespace - hierarchical organization of classes"
        };

        Console.Write("Enter a word: ");
        string word = Console.ReadLine();

        for (int i = 0; i < dictionary.Length; i++)
        {
            if (dictionary[i].StartsWith(word + " - "))
            {
                Console.WriteLine(dictionary[i]);
                return;
            }
        }

        Console.WriteLine("{0} was not found!", word);
    }
}

