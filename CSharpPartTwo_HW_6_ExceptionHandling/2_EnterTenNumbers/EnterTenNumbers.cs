using System;

class EnterTenNumbers
{
    static void Main()
    {
        try
        {
            for (int i = 0; i < 10; i++)
            {
                ReadNumber(i * 10, (i + 1) * 10);
            }
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Number cannot be null.");
        }
        catch (FormatException fe)
        {
            Console.WriteLine(fe.Message);
        }
        catch (OverflowException)
        {
            Console.WriteLine("Number is too large to be stored in Int32.");
        }
        catch (ArgumentOutOfRangeException aore)
        {
            Console.WriteLine(aore.Message);
        }
    }

    private static void ReadNumber(int start, int end)
    {
        Console.Write("Enter a number: ");

        int number = int.Parse(Console.ReadLine());

        if (number < start || number > end)
        {
            throw new ArgumentOutOfRangeException(string.Format(
                "The number must be in the interval [{0}, {1}]. Current value {2}.",
                start, end, number)); 
        }
    }
}

