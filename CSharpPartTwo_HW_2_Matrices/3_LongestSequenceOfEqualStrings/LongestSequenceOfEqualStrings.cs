using System;

class LongestSequenceOfEqualStrings
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("M = ");
        int m = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, m];

        Console.WriteLine("Start entering the content of the matrix (each element on a separate line).");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = Console.ReadLine();
            }
        }

        int bestCount = 0;
        string element = "";

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                string current = matrix[i, j];

                // Horizontal
                int col = j;
                int count = 0;
                while (col < m)
                {
                    if (matrix[i, col++] == current)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (bestCount < count)
                {
                    bestCount = count;
                    element = current;
                }

                // Vertical
                int row = i;
                count = 0;
                while (row < n)
                {
                    if (matrix[row++, j] == current)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (bestCount < count)
                {
                    bestCount = count;
                    element = current;
                }

                // First Diagonal
                row = i;
                col = j;
                count = 0;
                while (row < n && col < m)
                {
                    if (matrix[row++, col++] == current)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (bestCount < count)
                {
                    bestCount = count;
                    element = current;
                }

                // Second Diagonal
                row = i;
                col = j;
                count = 0;
                while (row < n && col >= 0)
                {
                    if (matrix[row++, col--] == current)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (bestCount < count)
                {
                    bestCount = count;
                    element = current;
                }
            }
        }

        // Print the Sequence
        Console.Write("Max sequence -> ");
        for (int i = 0; i < bestCount; i++)
        {
            Console.Write("{0} ", element);
        }
        Console.WriteLine();
    }
}

