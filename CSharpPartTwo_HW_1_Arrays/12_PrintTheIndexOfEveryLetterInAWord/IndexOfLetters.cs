using System;

class IndexOfLetters
{
    private const int ALPHABET_LENGTH = 26;

    static void Main()
    {
        char[] alphabet = new char[ALPHABET_LENGTH];

        int index = 0;
        for (char ch = 'A'; ch <= 'Z'; ch++)
        {
            alphabet[index++] = ch;
        }

        Console.Write("Enter a word: ");
        string word = Console.ReadLine().ToUpper();

        foreach (char ch in word)
        {
            for (int i = 0; i < ALPHABET_LENGTH; i++)
            {
                if (alphabet[i] == ch)
                {
                    Console.WriteLine("{0} - {1}", ch, i);
                }
            }
        }
    }
}

