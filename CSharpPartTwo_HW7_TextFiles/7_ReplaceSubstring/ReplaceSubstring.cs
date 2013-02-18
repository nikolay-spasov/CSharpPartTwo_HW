using System;
using System.IO;

class ReplaceSubstring
{
    private const string INPUT_FILE = "../../input.txt";
    private const string OUTPUT_FILE = "../../output.txt";

    static void Main()
    {
        using (StreamReader reader = new StreamReader(INPUT_FILE))
        {
            using (StreamWriter writer = new StreamWriter(OUTPUT_FILE))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line.Replace("start", "finish"));
                }
            }
        }
    }
}

