using System;
using System.Collections.Generic;
using System.IO;

class SortStrings
{
    private const string INPUT_FILE_NAME = "../../input.txt";
    private const string OUTPUT_FILE_NAME = "../../output.txt";

    static void Main()
    {
        string[] lines = GetStringsFromFile(INPUT_FILE_NAME);
        Array.Sort(lines);

        WriteSortedLinesToFile(OUTPUT_FILE_NAME, lines);
    }

    private static string[] GetStringsFromFile(string fileName)
    {
        string[] lines;
        using (StreamReader reader = new StreamReader(fileName))
        {
            lines = reader.ReadToEnd().Split(
                new string[] { Environment.NewLine }, StringSplitOptions.None);
        }

        return lines;
    }

    private static void WriteSortedLinesToFile(string fileName, string[] lines)
    {
        using (StreamWriter writer = new StreamWriter(OUTPUT_FILE_NAME))
        {
            foreach (string line in lines)
            {
                writer.WriteLine(line);
            }
        }
    }
}

