using System;
using System.IO;

class AreaWithMaximalSum
{
    private const string INPUT_FILE_NAME = "../../input.txt";
    private const string OUTPUT_FILE_NAME = "../../output.txt";

    static void Main()
    {
        int[,] matrix = GetMatrixFromFile(INPUT_FILE_NAME);
        int maxSum = GetMaximalSum(matrix);

        PrintMaxSumToFile(OUTPUT_FILE_NAME, maxSum);
    }

    private static int[,] GetMatrixFromFile(string fileName)
    {
        int[,] matrix;
        using (StreamReader reader = new StreamReader(fileName))
        {
            int n = int.Parse(reader.ReadLine());
            matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                string line = reader.ReadLine();
                string[] cols = line.Split(' ');

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = int.Parse(cols[col]);
                }
            }
        }

        return matrix;
    }

    private static int GetMaximalSum(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int maxSum = int.MinValue;

        for (int row = 0; row < n - 1; row++)
        {
            for (int col = 0; col < n - 1; col++)
            {
                int sum = 0;
                sum += matrix[row, col];
                sum += matrix[row, col + 1];
                sum += matrix[row + 1, col];
                sum += matrix[row + 1, col + 1];

                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
        }

        return maxSum;
    }

    private static void PrintMaxSumToFile(string fileName, int maxSum)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(maxSum.ToString());
        }
    }
}

