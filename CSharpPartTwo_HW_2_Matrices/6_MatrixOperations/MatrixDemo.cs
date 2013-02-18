using System;

class MatrixDemo
{
    public static void Main()
    {
        int[,] m1 = new int[,]
        {
            { 1, 2 },
            { 5, 6 }
        };

        int[,] m2 = new int[,]
        {
            { 5, 4 },
            { 3, 1 }
        };

        Matrix matrix1 = new Matrix(m1);
        Matrix matrix2 = new Matrix(m2);

        Console.WriteLine("Sum");
        Console.Write(matrix1 + matrix2);

        Console.WriteLine("Difference");
        Console.Write(matrix1 - matrix2);

        Matrix mul = matrix1 * matrix2;

        Console.WriteLine("Product");
        Console.Write(matrix1 * matrix2);
    }
}

