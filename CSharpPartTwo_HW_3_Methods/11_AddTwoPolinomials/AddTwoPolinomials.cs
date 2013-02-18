using System;

class AddTwoPolinomials
{
    static void Main()
    {
        int[] a = { 5, 0, 1 }; // x^2 + 0x + 5
        int[] b = { 5, 0, 1 }; // x^2 + 0x + 5

        int[] c = AddPolinomials(a, b);  // 2x^2 + 10

        c = SubtractPolinomials(a, b); // 0x^2 + 0x + 0

        c = MultiplyPolinomials(a, b); // 1x^4 + 0x^2 + 25

        for (int i = c.Length - 1; i >= 0; i--)
        {
            Console.Write("{0} ", c[i]);
        }
        Console.WriteLine();
    }

    static int[] AddPolinomials(int[] a, int[] b)
    {
        if (a.Length != b.Length)
        {
            throw new ArgumentException("Arrays are with different lengths");
        }

        int[] result = new int[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            result[i] = a[i] + b[i];
        }

        return result;
    }

    static int[] SubtractPolinomials(int[] a, int[] b)
    {
        if (a.Length != b.Length)
        {
            throw new ArgumentException("Arrays are with different lengths");
        }

        int[] result = new int[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            result[i] = a[i] - b[i];
        }

        return result;
    }

    static int[] MultiplyPolinomials(int[] a, int[] b)
    {
        if (a.Length != b.Length)
        {
            throw new ArgumentException("Arrays are with different lengths");
        }

        int[] result = new int[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            result[i] = a[i] * b[i];
        }

        return result;
    }
   
}

