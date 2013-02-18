using System;

class SequenceWithGivenSum
{
    static void Main()
    {
        //int[] numbers = { 4, 3, 1, 4, 2, 5, 8};
        Console.Write("Enter the sum you are looking for: ");
        int sum = int.Parse(Console.ReadLine());
        int[] numbers = GetArrayFromUser();
        
        int start = 0;
        int end = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int currentSum = 0;
            for (int j = i; j < numbers.Length; j++)
            {
                currentSum += numbers[j];
                if (currentSum == sum)
                {
                    start = i;
                    end = j;
                }
            }
        }

        Console.Write("{ ");
        for (int i = start; i <= end; i++)
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

