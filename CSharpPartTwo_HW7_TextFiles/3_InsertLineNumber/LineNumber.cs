using System;
using System.IO;

class LineNumber
{
    private const string INPUT_FILE_NAME = "../../input.txt";
    private const string OUTPUT_FILE_NAME = "../../output.txt";

    static void Main()
    {
        using (StreamReader reader = new StreamReader(INPUT_FILE_NAME))
        {
            using (StreamWriter writer = new StreamWriter(OUTPUT_FILE_NAME))
            {
                int lineNumber = 1;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine("{0}. {1}", lineNumber, line);
                    lineNumber++;
                }
            }
        }
    }
}

