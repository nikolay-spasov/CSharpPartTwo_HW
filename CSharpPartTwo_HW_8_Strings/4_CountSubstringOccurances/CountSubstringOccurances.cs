using System;

class CountSubstringOccurances
{
    static void Main()
    {
        //string text = "we are living in an yellow submarine. we don't have anything else. " +
        //    "inside the submarine is very tight. so we are drinking all the day. " +
        //    "we will move out of it in 5 days.";
        //string sub = "in";

        Console.WriteLine("Enter some text: ");
        string text = Console.ReadLine();
        Console.WriteLine("Enter the substring you want to count.");
        string sub = Console.ReadLine();
        
        int index = 0;
        int count = 0;
        while (true)
        {
            int i = text.IndexOf(sub, index, StringComparison.InvariantCultureIgnoreCase);
            
            if (i == -1)
            {
                break;
            }

            index = ++i;
            count++;
        }

        Console.WriteLine("The result is: {0}", count);
    }
}

