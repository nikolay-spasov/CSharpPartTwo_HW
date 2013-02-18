using System;
using System.Text.RegularExpressions;

class ReplaceForbiddenWords
{
    static void Main()
    {
        //string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        //string[] forbiddenWords = { "PHP", "CLR", "Microsoft" };

        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();
        Console.WriteLine("Enter forbidden words separated by comma: ");
        string[] forbiddenWords = Console.ReadLine().Split(new string[] { " ", "," }, 
            StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in forbiddenWords)
        {
            string pattern = string.Format(@"\b{0}\b", word);
            text = Regex.Replace(text, pattern, new string('*', word.Length));
        }

        Console.WriteLine(text);
    }
}

