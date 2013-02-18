using System;
using System.Text;

class ReverseDigitsOfNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int result = ReverseDigits(number);

        Console.WriteLine("{0} -> {1}", number, result);
    }

    static int ReverseDigits(int number)
    {
        string strNumber = number.ToString();
        StringBuilder builder = new StringBuilder();

        for (int i = strNumber.Length - 1; i >= 0; i--)
        {
            builder.Append(strNumber[i]);
        }

        return int.Parse(builder.ToString());
    }
}

