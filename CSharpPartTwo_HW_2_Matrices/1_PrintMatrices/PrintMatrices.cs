using System;

class PrintMatrices
{
    static void Main()
    {
        Console.WriteLine("Enter which matrice to print (A, B, C or D)");
        string input = Console.ReadLine().ToUpper();
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        switch (input)
        {
            case "A":
                PrintFirstMatrix(n);
                break;
            case "B":
                PrintSecondMatrix(n);
                break;
            case "C":
                PrintThirdMatrix(n);
                break;
            case "D":
                PrintFourthMatrix(n);
                break;
            default:
                break;
        }
    }

    public static void PrintFirstMatrix(int n)
    {
        int[,] matrix = new int[n, n];
        int counter = 1;

        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[row, col] = counter;
                counter++;
            }
        }

        PrintMatrix(matrix);
    }

    public static void PrintSecondMatrix(int n)
    {
        int[,] matrix = new int[n, n];
        int counter = 1;

        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                if (col % 2 == 0)
                {
                    matrix[row, col] = counter++;
                }
                else
                {
                    matrix[n - 1 - row, col] = counter++;
                }
            }
        }

        PrintMatrix(matrix);
    }

    public static void PrintThirdMatrix(int n)
    {
        int[,] matrix = new int[n, n];
        int counter = 1;
        int startRow = n - 1;
        int startCol = 0;


        while (!(startRow == 0 && startCol == n - 1))
        {
            // Populate diagonal
            int row = startRow;
            int col = startCol;

            while (row < n && col < n)
            {
                matrix[row, col] = counter++;
                row++;
                col++;
            }

            startRow--;
            if (startRow < 0)
            {
                startRow = 0;
                startCol++;
            }
        }

        matrix[0, n - 1] = n * n;

        PrintMatrix(matrix);
    }

    public static void PrintFourthMatrix(int n)
    {
        int[,] matrix = new int[n, n];
        int counter = 1;
        int row = 0;
        int col = 0;
        int direction = 0;
        int currentStep = 0;
        int maxStep = n;

        while (counter <= n * n)
        {
            matrix[row, col] = counter;
            currentStep++;

            if (currentStep == maxStep)
            {
                direction = (direction + 1) % 4;
                if (direction == 1 || direction == 3)
                {
                    maxStep--;
                }

                currentStep = 0;
            }

            switch (direction)
            {
                case 0:
                    row++;
                    break;
                case 1:
                    col++;
                    break;
                case 2:
                    row--;
                    break;
                case 3:
                    col--;
                    break;
            }

            counter++;
        }

        PrintMatrix(matrix);
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}