using System;
using System.Collections.Generic;

class LettersCount
{
    static void Main()
    {
        string str = Console.ReadLine();

        Dictionary<char, int> letterToOccurances = new Dictionary<char, int>();

        foreach (char ch in str)
        {
            if (!letterToOccurances.ContainsKey(ch))
            {
                letterToOccurances.Add(ch, 1);
            }
            else
            {
                letterToOccurances[ch]++;
            }
        }

        foreach (var key in letterToOccurances.Keys)
        {
            Console.WriteLine("{0} -> {1}", key, letterToOccurances[key]);
        }
    }
}

