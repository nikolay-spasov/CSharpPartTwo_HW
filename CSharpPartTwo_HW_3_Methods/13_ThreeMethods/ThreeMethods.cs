using System;
using System.Text;

class ThreeMethods
{
    static void Main()
    {
        Console.WriteLine("Select what to do: ");
        Console.WriteLine("1. Reverse the digits of a number.");
        Console.WriteLine("2. Calculate the average of a sequence of integers.");
        Console.WriteLine("3. Solve a linera equotion a * x + b = 0.");
        Console.WriteLine("0. Exit.");

        int choice;
        if (int.TryParse(Console.ReadLine(), out choice))
        {
            switch (choice)
            {
                case 0:
                    return;
                case 1:
                    ReverseDigits();
                    break;
                case 2:
                    CalculateAverage();
                    break;
                case 3:
                    SolveLinearEquation();
                    break;
                default:
                    Console.WriteLine("Invalid choice - {0}", choice);
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }

    static void ReverseDigits()
    {
        Console.WriteLine("Enter a number.");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("The number must be non-negative.");
            return;
        }

        string strNumber = number.ToString();
        StringBuilder builder = new StringBuilder();

        for (int i = strNumber.Length - 1; i >= 0; i--)
        {
            builder.Append(strNumber[i]);
        }

        Console.WriteLine("{0} -> {1}", number, builder.ToString());
    }

    static void CalculateAverage()
    {
        Console.WriteLine("Enter the numbers. [a b c d ...]");
        string[] seq = Console.ReadLine().Split(' ');

        if (seq.Length == 0)
        {
            Console.WriteLine("Sequence is empty.");
            return;
        }

        int sum = 0;
        foreach (var num in seq)
        {
            sum += int.Parse(num);
        }

        double ave = (double)sum / (double)seq.Length;

        Console.WriteLine("Average = {0}", ave);
    }

    static void SolveLinearEquation()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        if (a < 0)
        {
            Console.WriteLine("a shoud not be negative.");
            return;
        }
        Console.WriteLine("b = ");
        double b = double.Parse(Console.ReadLine());

        double x = -b / a;

        Console.WriteLine("x = {0}", x);
    }
}

