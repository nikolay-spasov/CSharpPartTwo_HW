using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;

class RemoveWords
{
    private const string WORDS_FILE = "../../words.txt";
    private const string TEXT_FILE = "../../text.txt";

    static void Main()
    {
        try
        {
            HashSet<string> words = GetWordsFromFile(WORDS_FILE);

            string text = GetFileConent(TEXT_FILE);

            foreach (string word in words)
            {
                string pattern = string.Format(@"\b{0}\b", word);
                text = Regex.Replace(text, pattern, "");
            }

            WriteResultToFile(TEXT_FILE, text);
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine(fnfe.Message);
        }
        catch (DirectoryNotFoundException dnfe)
        {
            Console.WriteLine(dnfe.Message);
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
        catch (SecurityException se)
        {
            Console.WriteLine(se.Message);
        }
        catch (UnauthorizedAccessException uae)
        {
            Console.WriteLine(uae.Message);
        }
    }

    private static void WriteResultToFile(string fileName, string result)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.Write(result);
        }
    }

    private static string GetFileConent(string fileName)
    {
        string result = "";

        using (StreamReader reader = new StreamReader(fileName))
        {
            result = reader.ReadToEnd();
        }
        
        return result;
    }

    private static HashSet<string> GetWordsFromFile(string fileName)
    {
        HashSet<string> result = new HashSet<string>();
        
        using (StreamReader reader = new StreamReader(WORDS_FILE))
        {
            string fileContent = reader.ReadToEnd();

            foreach (var word in fileContent.Split(new string[] { " ", Environment.NewLine },
                StringSplitOptions.RemoveEmptyEntries))
            {
                result.Add(word);
            }
        }
        
        return result;
    }
}

