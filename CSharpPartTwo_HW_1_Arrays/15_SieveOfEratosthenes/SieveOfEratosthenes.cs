using System;

class SieveOfEratosthenes
{
    private const int N = 10000000;

    static void Main()
    {
        bool[] a = new bool[N];

        for (int i = 0; i < N; i++)
        {
            a[i] = true;
        }

        int sqrtN = (int)Math.Sqrt(N);

        for (int i = 2; i < sqrtN; i++)
        {
            if (a[i])
            {
                int iSquare = i * i;
                int coeff = 1;
                for (int j = iSquare; j < N; j += (coeff * i))
                {
                    a[j] = false;
                }
            }
        }

        for (int i = 1; i < N; i++)
        {
            if (a[i])
            {
                Console.WriteLine(i);
            }
        }
    }
}
