using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        // Basic email pattern from the internet. It seems to work.
        string pattern = @"[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}";
        string text = Console.ReadLine();

        var matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

        foreach (var email in matches)
        {
            Console.WriteLine(email);
        }
    }
}

