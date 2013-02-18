using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class ReverseWords
{
    static void Main()
    {
        //string sentence = "C# is not C++, not PHP and not Delphi!";

        Console.WriteLine("Enter a sentence: ");
        string sentence = Console.ReadLine();

        sentence = " " + sentence;
        StringBuilder builder = new StringBuilder();
        List<char> buffer = new List<char>();
        for (int i = sentence.Length - 1; i >= 0; i--)
        {
            if (sentence[i] == '.' || sentence[i] == '!' || sentence[i] == '?')
            {
                continue;
            }

            buffer.Add(sentence[i]);
            if (sentence[i] == ' ')
            {
                AddWordBackwars(buffer.ToArray(), builder);
                buffer.Clear();
            }
        }

        if (buffer.Count != 0)
        {
            AddWordBackwars(buffer.ToArray(), builder);
        }

        string result = builder.ToString().Trim();
        result += sentence[sentence.Length - 1];
        Console.WriteLine(result);
    }

    private static void AddWordBackwars(char[] word, StringBuilder builder)
    {
        for (int i = word.Length - 1; i >= 0; i--)
        {
            builder.Append(word[i]);
        }
    }
}

