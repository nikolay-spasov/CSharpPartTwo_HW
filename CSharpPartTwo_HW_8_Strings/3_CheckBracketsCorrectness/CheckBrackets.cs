using System;

class CheckBrackets
{
    static void Main()
    {
        string expression = Console.ReadLine();

        int openBrackets = 0;
        bool isCorrect = true;

        foreach (var ch in expression)
        {
            if (ch == '(')
            {
                openBrackets++;
            }
            else if (ch == ')')
            {
                openBrackets--;
            }

            if (openBrackets < 0)
            {
                isCorrect = false;
                break;
            }
        }

        if (isCorrect && openBrackets == 0)
        {
            Console.WriteLine("Expression is correct.");
        }
        else
        {
            Console.WriteLine("Expression is not correct.");
        }
    }
}

