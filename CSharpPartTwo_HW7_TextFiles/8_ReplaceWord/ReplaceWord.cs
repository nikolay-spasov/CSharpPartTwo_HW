using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceWord
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
                string pattern = @"\bstart\b";

                while ((line = reader.ReadLine()) != null)
                {
                    string replaced = Regex.Replace(line, pattern, "finish");
                    writer.WriteLine(replaced);
                }
            }
        }
    }
}

