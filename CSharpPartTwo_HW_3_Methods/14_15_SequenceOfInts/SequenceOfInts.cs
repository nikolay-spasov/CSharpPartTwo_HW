using System;
using System.Linq;

class SequenceOfInts
{
    static void Main()
    {
        double min = Min<double>(0.3, 13.1, 14.3);
        double max = Max<double>(0.3, 13.1, 14.3);
        double sum = Sum<double>(0.3, 13.1, 14.3);
        double ave = Ave<double>(0.3, 13.1, 14.3);
        double product = Product<double>(0.3, 13.1, 14.3);

        Console.WriteLine("Min = {0}", min);
        Console.WriteLine("Max = {0}", max);
        Console.WriteLine("Sum = {0}", sum);
        Console.WriteLine("Ave = {0}", ave);
        Console.WriteLine("Product = {0}", product);
    }

    static T Min<T>(params T[] elements)
    {
        return elements.Min<T>();
    }

    static T Max<T>(params T[] elements)
    {
        return elements.Max<T>();
    }

    static T Sum<T>(params T[] elements)
    {
        dynamic sum = elements[0];

        for (int i = 1; i < elements.Length; i++)
        {
            sum += elements[i];
        }

        return sum;
    }

    static double Ave<T>(params T[] elements)
    {
        dynamic sum = elements[0];

        for (int i = 1; i < elements.Length; i++)
        {
            sum += elements[i];
        }

        return (double)sum / (double)elements.Length;
    }

    static T Product<T>(params T[] elements)
    {
        dynamic product = 1;

        foreach (T element in elements)
        {
            product *= element;
        }

        return product;
    }
}

