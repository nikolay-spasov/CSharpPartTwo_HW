using System;
using System.IO;

class CompareTwoFiles
{
    private const string FIRST_FILE_NAME = "../../input1.txt";
    private const string SECOND_FILE_NAME = "../../input2.txt";

    static void Main()
    {
        int equalLinesCount = 0;
        int differentLinesCount = 0;

        using (StreamReader firstReader = new StreamReader(FIRST_FILE_NAME))
        {
            using (StreamReader secondReader = new StreamReader(SECOND_FILE_NAME))
            {
                string line;

                while ((line = firstReader.ReadLine()) != null)
                {
                    if (line == secondReader.ReadLine())
                    {
                        equalLinesCount++;
                    }
                    else
                    {
                        differentLinesCount++;
                    }
                }
            }
        }

        Console.WriteLine("Equal lines: {0}", equalLinesCount);
        Console.WriteLine("Different lines: {0}", differentLinesCount);
    }
}

