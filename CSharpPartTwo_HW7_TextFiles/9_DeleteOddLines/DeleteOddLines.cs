using System;
using System.Collections.Generic;
using System.IO;

class DeleteOddLines
{
    private const string FILE_NAME = "../../TheFile.txt";

    static void Main()
    {
        List<string> lines = new List<string>();
        using (StreamReader reader = new StreamReader(FILE_NAME))
        {
            string line;
            int lineNumber = 1;
            while ((line = reader.ReadLine()) != null)
            {
                if (lineNumber % 2 == 0)
                {
                    lines.Add(line);
                }
                lineNumber++;
            }
        }

        using (StreamWriter writer = new StreamWriter(FILE_NAME))
        {
            foreach (var line in lines)
            {
                writer.WriteLine(line);
            }
        }
    }
}

