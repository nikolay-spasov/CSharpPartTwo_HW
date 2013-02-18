using System;
using System.Text;

public class Matrix
{
    private int[,] matrix;

    private Matrix(int n, int m)
    {
        this.matrix = new int[n, m];
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                this.matrix[row, col] = 0;
            }
        }
    }

    public Matrix(int[,] matrix)
    {
        this.matrix = matrix;
    }

    public static Matrix operator +(Matrix first, Matrix second)
    {
        if (first.matrix.GetLength(0) != second.matrix.GetLength(0) ||
            first.matrix.GetLength(1) != second.matrix.GetLength(1))
        {
            throw new InvalidOperationException(
                "Matrix sizes are not the equal. Cannot add matrices.");
        }

        Matrix result = new Matrix(first.matrix.GetLength(0), 
            first.matrix.GetLength(1));

        for (int row = 0; row < result.matrix.GetLength(0); row++)
        {
            for (int col = 0; col < result.matrix.GetLength(1); col++)
            {
                result[row, col] = first[row, col] + second[row, col];
            }
        }

        return result;
    }

    public static Matrix operator -(Matrix first, Matrix second)
    {
        if (first.matrix.GetLength(0) != second.matrix.GetLength(0) ||
            first.matrix.GetLength(1) != second.matrix.GetLength(1))
        {
            throw new InvalidOperationException(
                "Matrix sizes are not the equal. Cannot add matrices.");
        }

        Matrix result = new Matrix(first.matrix.GetLength(0),
            first.matrix.GetLength(1));

        for (int row = 0; row < result.matrix.GetLength(0); row++)
        {
            for (int col = 0; col < result.matrix.GetLength(1); col++)
            {
                result[row, col] = first[row, col] - second[row, col];
            }
        }

        return result;
    }

    public static Matrix operator *(Matrix first, Matrix second)
    {
        if (first.matrix.GetLength(1) != second.matrix.GetLength(0))
        {
            throw new InvalidOperationException(
                "Matrices are not suitable for multiplication.");
        }

        int n = first.matrix.GetLength(0);
        int m = second.matrix.GetLength(1);
        Matrix result = new Matrix(n, m);

        for (int i = 0; i < result.matrix.GetLength(0); i++)
        {
            for (int j = 0; j < result.matrix.GetLength(1); j++)
            {
                for (int k = 0; k < first.matrix.GetLength(1); k++)
                {
                    result[i, j] += (first[i, k] * second[k, j]);
                }
            }
        }

        return result;
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                builder.AppendFormat("{0, 3}", this[row, col]);
            }
            builder.AppendLine();
        }

        return builder.ToString();
    }

    public int this[int row, int col]
    {
        get
        {
            if (row < 0 || col < 0 || row >= matrix.GetLength(0) ||
                col >= matrix.GetLength(1))
            {
                throw new IndexOutOfRangeException(
                    "Index is out of range");
            }

            return matrix[row, col];
        }

        private set
        {
            if (row < 0 || col < 0 || row >= matrix.GetLength(0) ||
                col >= matrix.GetLength(1))
            {
                throw new IndexOutOfRangeException(
                    "Index is out of range");
            }

            this.matrix[row, col] = value;
        }
    }
}

