using System;
using System.IO;

class PrintOddLines
{
    private const string FILE_NAME = @"../../Input.txt";

    static void Main()
    {
        try
        {
            using (StreamReader reader = new StreamReader(FILE_NAME))
            {
                string line;
                int counter = 1;
                while ((line = reader.ReadLine()) != null)
                {
                    if (counter % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }

                    counter++;
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File: {0} was not found!", FILE_NAME);
        }
        catch (IOException)
        {
            Console.WriteLine("Cannot open file: {0}", FILE_NAME);
        }
    }
}
