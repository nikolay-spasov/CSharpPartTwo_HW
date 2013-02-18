using System;
using System.IO;
using System.Security;

class ReadAFile
{
    static void Main()
    {
        Console.Write("Enter the full path of the file you want to read: ");
        string filePath = "";
        try
        {
            filePath = Console.ReadLine();

            if (filePath == null)
            {
                throw new ArgumentNullException("File path cannot be null.");
            }

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        catch (ArgumentNullException ane)
        {
            Console.WriteLine(ane.Message);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid file path. Path is either zero-length string or " +
                "contains only empty spaces or it contains invalid characters.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("File path too long. For windows-based platforms path must be " +
                "less than 248 characters and file name must be less tha 260 characters");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Path: {0} is in invalid format.", filePath);
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Cannot access directory. Make sure you are not trying to read from an unmapped drive.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File: {0} cannot be found.", filePath);
        }
        catch (SecurityException)
        {
            Console.WriteLine("Permission to open file: {0} is required.", filePath);
        }
        catch (IOException)
        {
            Console.WriteLine("Unexpected result while trying to access file: {0}. Make sure " +
                "you are not trying to read from an unmapped drive.", filePath);
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("The operation is not supported on current platform.");
        }
    }
}

