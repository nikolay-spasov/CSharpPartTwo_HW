using System;

class UppercaseText
{
    private const string OPENING_TAG = "<upcase>";
    private const string CLOSING_TAG = "</upcase>";

    static void Main()
    {
        //string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();

        int counter = 0;
        while (true)
        {
            int open = text.IndexOf(OPENING_TAG, 0);
            int close = text.IndexOf(CLOSING_TAG, 0);

            if (open == -1 || close == -1)
            {
                break;
            }

            string sub = text.Substring(open + OPENING_TAG.Length, 
                close - open - CLOSING_TAG.Length + 1);
            text = text.Replace(OPENING_TAG + sub + CLOSING_TAG, sub.ToUpper());

            counter++;
        }

        Console.WriteLine(counter);
        Console.WriteLine(text);
    }
}

