using System;

class MaximalSumSequence
{
    static void Main()
    {
        //int[] numbers = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        int[] numbers = GetArrayFromUser();

        int maxSoFar = numbers[0];
        int maxEndingHere = numbers[0];
        int beginTemp = 0;
        int begin = 0;
        int end = 0;

        for (int i = 1; i < numbers.Length; i++)
        {
            maxEndingHere += numbers[i];
            if (numbers[i] > maxEndingHere)
            {
                maxEndingHere = numbers[i];
                beginTemp = i;
            }

            if (maxEndingHere > maxSoFar)
            {
                maxSoFar = maxEndingHere;
                begin = beginTemp;
                end = i;
            }
        }

        Console.Write("{ ");
        for (int i = begin; i <= end; i++)
        {
            Console.Write("{0} ", numbers[i]);
        }
        Console.WriteLine("}");
    }

    public static int[] GetArrayFromUser()
    {
        Console.Write("Length = ");
        int n = int.Parse(Console.ReadLine());
        int[] result = new int[n];
        Console.WriteLine("Start entering numbers.");
        for (int i = 0; i < n; i++)
        {
            result[i] = int.Parse(Console.ReadLine());
        }

        return result;
    }
}

