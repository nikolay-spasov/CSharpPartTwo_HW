using System;
using System.Collections.Generic;

class Palindromes
{
    static void Main()
    {
        //string text = "Pesho likes ABBA. I don't think lamal is a word. This exe will harm your computer.";

        Console.WriteLine("Enter some text: ");
        string text = Console.ReadLine();

        string[] words = text.Split(new string[] { " ", ".", ",", "!", "?" },
            StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            if (IsPalindrome(word))
            {
                Console.Write("{0} ", word);
            }
        }

        Console.WriteLine();
    }

    private static bool IsPalindrome(string word)
    {
        if (word.Length == 1)
        {
            return false;
        }

        for (int i = 0; i < word.Length / 2; i++)
        {
            if (word[i] != word[word.Length - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}

