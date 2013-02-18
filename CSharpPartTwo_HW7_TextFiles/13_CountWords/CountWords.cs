using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Security;

class CountWords
{
    private const string WORDS_FILE_NAME = "../../words.txt";
    private const string TEST_FILE_NAME = "../../test.txt";
    private const string RESULT_FILE_NAME = "../../result.txt";

    private static string[] separators = { Environment.NewLine, " ", ".", "!", "?", "\t" };

    static void Main()
    {
        try
        {
            HashSet<string> words = GetWordsFromFile(WORDS_FILE_NAME);
            Dictionary<string, int> wordsToCounts = WordsToCounts(TEST_FILE_NAME, words);

            WriteResultToFile(RESULT_FILE_NAME,
                wordsToCounts.OrderByDescending(x => x.Value));
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

    private static void WriteResultToFile(string fileName, 
        IEnumerable<KeyValuePair<string, int>> wordCounts)
    {
        using (StreamWriter writer = new StreamWriter(RESULT_FILE_NAME))
        {
            foreach (var word in wordCounts)
            {
                writer.WriteLine("{0} -> {1}", word.Key, word.Value);
            }
        }
    }

    private static HashSet<string> GetWordsFromFile(string fileName)
    {
        string fileContent = "";
        
        using (StreamReader reader = new StreamReader(fileName))
        {
            fileContent = reader.ReadToEnd();
        }

        HashSet<string> words = new HashSet<string>(
            fileContent.Split(separators, StringSplitOptions.None));
        return words;
    }

    private static Dictionary<string, int> WordsToCounts(string fileName, HashSet<string> words)
    {
        Dictionary<string, int> wordsToCounts = new Dictionary<string, int>();

        foreach (var word in words)
        {
            wordsToCounts.Add(word, 0);
        }

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] wordsInFile = line.Split(separators, StringSplitOptions.None);
                foreach (string word in wordsInFile)
                {
                    if (wordsToCounts.ContainsKey(word))
                    {
                        wordsToCounts[word]++;
                    }
                }
            }
        }

        return wordsToCounts;
    }
}

