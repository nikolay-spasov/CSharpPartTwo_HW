using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWords
{
    private const string FILE_NAME = "../../text.txt";
    private const string PREFIX = "test";

    static void Main()
    {
        string fileContent = "";
        using (StreamReader reader = new StreamReader(FILE_NAME))
        {
            fileContent = reader.ReadToEnd();
        }

        string pattern = string.Format(@"\b{0}\w*", PREFIX);
        string result = Regex.Replace(fileContent, pattern, "");

        using (StreamWriter writer = new StreamWriter(FILE_NAME))
        {
            foreach (var ch in result)
            {
                writer.Write(ch);
            }
        }
    }
}

