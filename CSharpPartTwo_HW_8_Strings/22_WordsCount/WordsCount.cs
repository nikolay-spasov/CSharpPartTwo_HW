using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class WordsCount
{
    static void Main()
    {
        //string str = "word and word, and words and, word, again and some commas here and there.";

        string pattern = @"\w+";
        string str = Console.ReadLine();

        Dictionary<string, int> wordsToCounts = new Dictionary<string, int>();

        foreach (Match word in Regex.Matches(str, pattern))
        {
            if (!wordsToCounts.ContainsKey(word.Value))
            {
                wordsToCounts.Add(word.Value, 1);
            }
            else
            {
                wordsToCounts[word.Value]++;
            }
        }

        foreach (var key in wordsToCounts.Keys)
        {
            Console.WriteLine("{0} -> {1}", key, wordsToCounts[key]);
        }
    }
}

