using System;
using System.Collections;
using System.Collections.Generic;

class LargestAreaOfEqualNeighbors
{
    struct Field
    {
        public int Row;
        public int Col;

        public Field(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
    };

    static void Main()
    {
        int[,] matrix = new int[,]
        {
            { 1, 3, 2, 2, 2, 4 },
            { 3, 3, 3, 2, 4, 4 },
            { 4, 3, 1, 2, 3, 3 },
            { 4, 3, 1, 3, 3, 1 },
            { 4, 3, 3, 3, 1, 1 }
        };

        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        bool[,] visitedCells = new bool[n, m];

        Queue<Field> q = new Queue<Field>();
        int[] dRow = { 0, 1, 0, -1 };
        int[] dCol = { -1, 0, 1, 0 };

        int maxLength = 0;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (visitedCells[row, col])
                {
                    continue;
                }

                visitedCells[row, col] = true;
                int currentValue = matrix[row, col];
                int length = 1;

                q.Enqueue(new Field(row, col));

                while (q.Count > 0)
                {
                    Field next = q.Dequeue();
                    for (int i = 0; i < 4; i++)
                    {
                        next.Row += dRow[i];
                        next.Col += dCol[i];

                        if (next.Row >= 0 && next.Col >= 0 && next.Row < n && next.Col < m &&
                            !visitedCells[next.Row, next.Col] && matrix[next.Row, next.Col] == currentValue)
                        {
                            length++;
                            visitedCells[next.Row, next.Col] = true;
                            q.Enqueue(next);
                        }
                    }
                }

                if (length > maxLength)
                {
                    maxLength = length;
                }
            }
        }

        Console.WriteLine(maxLength);
    }
}

