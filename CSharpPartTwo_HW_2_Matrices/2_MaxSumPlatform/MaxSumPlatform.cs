using System;

class MaxSumPlatform
{
    static void Main()
    {
        //int[,] matrix = new int[,]
        //{
        //    { 1, 2, 5, 6, 10 },
        //    { 3, 5, 1, 6, 2 },
        //    { 2, 2, 2, 2, 2 },
        //    { 5, 1, 3, 8, 280 }
        //};

        //int n = 4;
        //int m = 5;

        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("M = ");
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = GetMatrixFromUser(n, m);

        int maxSum = int.MinValue;

        for (int i = 0; i < n - 2; i++)
        {
            for (int j = 0; j < m - 2; j++)
            {
                int sum = matrix[i, j];
                sum += matrix[i, j + 1];
                sum += matrix[i, j + 2];
                sum += matrix[i + 1, j];
                sum += matrix[i + 1, j + 1];
                sum += matrix[i + 1, j + 2];
                sum += matrix[i + 2, j];
                sum += matrix[i + 2, j + 1];
                sum += matrix[i + 2, j + 2];

                if (maxSum < sum)
                {
                    maxSum = sum;
                }
            }
        }

        Console.WriteLine("Maximal Sum = {0}", maxSum);
    }

    private static int[,] GetMatrixFromUser(int n, int m)
    {
        Console.WriteLine("Start entering the numbers (each on a separate line)");
        int[,] matrix = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        return matrix;
    }
}

