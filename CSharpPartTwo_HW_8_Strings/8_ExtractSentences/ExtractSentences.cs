using System;
using System.Text;
using System.Text.RegularExpressions;

class ExtractSentences
{
    static void Main()
    {
        //string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        //string word = "in";

        Console.WriteLine("Enter some text. Each sentence must end with a dot.");
        string text = Console.ReadLine();
        Console.WriteLine("Enter the word you are searching for: ");
        string word = Console.ReadLine();

        string[] sentences = text.Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);

        StringBuilder result = new StringBuilder();
        foreach (string sentence in sentences)
        {
            string[] words = Regex.Split(sentence, "\\b");

            bool hasWord = false;
            foreach (string w in words)
            {
                if (string.Equals(w, word, StringComparison.InvariantCultureIgnoreCase))
                {
                    hasWord = true;
                    break;
                }
            }

            if (hasWord)
            {
                result.AppendFormat("{0}.\n", sentence.Trim());
            }
        }

        Console.Write(result);
    }
}

