using System;
using System.IO;

class ConcatenateTwoTextFiles
{
    private const string FIRST_FILE_NAME = @"../../Input1.txt";
    private const string SECOND_FILE_NAME = @"../../Input2.txt";
    private const string RESULT_FILE_NAME = @"../../Output.txt";

    static void Main()
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(RESULT_FILE_NAME, true))
            {
                writer.AutoFlush = true;

                using (StreamReader reader = new StreamReader(FIRST_FILE_NAME))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(line);
                    }
                }

                using (StreamReader reader = new StreamReader(SECOND_FILE_NAME))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(line);
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {

        }
        catch (IOException)
        {

        }
    }
}

