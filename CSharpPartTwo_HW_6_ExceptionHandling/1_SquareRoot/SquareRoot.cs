using System;

class SquareRoot
{
    static void Main()
    {
        Console.Write("Enter a number: ");

        try
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(string.Format(
                    "Invalid value: {0}. Value must be positive integer.", number));
            }

            double result = Math.Sqrt(number);

            Console.WriteLine("Sqrt({0}) = {1}", number, result);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Number cannot be null.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Number is too large to be stored in Int32.");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number.");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}

