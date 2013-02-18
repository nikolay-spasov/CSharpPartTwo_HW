using System;
using System.Collections.Generic;

class AddTwoBigIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter the numbers you want to add.");
        string line1 = Console.ReadLine();
        string line2 = Console.ReadLine();

        int[] a = new int[line1.Length];
        int[] b = new int[line2.Length];

        for (int i = line1.Length - 1; i >= 0; i--)
        {
            a[line1.Length - 1 - i] = int.Parse(line1[i].ToString());
        }

        for (int i = line2.Length - 1; i >= 0; i--)
        {
            b[line2.Length - 1 - i] = int.Parse(line2[i].ToString());
        }

        int[] result = Add(a, b);

        foreach (var i in result)
        {
            Console.Write("{0}", i);
        }
        Console.WriteLine();
    }

    static int[] Add(int[] a, int[] b)
    {
        int maxLength = Math.Max(a.Length, b.Length);
        Stack<int> stack = new Stack<int>();

        int carry = 0;
        for (int i = 0; i < maxLength; i++)
        {
            int digit = 0;

            if (i < a.Length)
            {
                digit += a[i];
            }
            if (i < b.Length)
            {
                digit += b[i];
            }

            digit += carry;

            carry = digit / 10;
            stack.Push(digit % 10);
        }

        if (carry != 0)
        {
            stack.Push(carry);
        }

        int[] arr = new int[stack.Count];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = stack.Pop();
        }

        return arr;
    }
}

