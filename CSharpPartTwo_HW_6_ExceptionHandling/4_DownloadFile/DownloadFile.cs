using System;
using System.IO;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        WebClient client = new WebClient();
        string remoteAddress = "";
        string fileName = "";

        try
        {
            Console.WriteLine("Enter the URI of the resource you want to download: ");
            remoteAddress = Console.ReadLine();

            // remoteAddress = "http://www.devbg.org/img/Logo-BASD.jpg";

            Uri uri = new Uri(remoteAddress);

            fileName = Path.GetFileName(uri.LocalPath);
            client.DownloadFile(uri, fileName);

            Console.WriteLine("File {0} was downloaded successfully.", fileName);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The address cannot be null.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Path: {0} contains invalid characters.", remoteAddress);
        }
        catch (UriFormatException)
        {
            Console.WriteLine("{0} is invalid Uri format.", remoteAddress);
        }
        catch (WebException)
        {
            Console.WriteLine("The file at: {0} does not exists, or address is invalid.",
                remoteAddress);
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Method {0} has been called simultaneously on multiple threads.",
                "WebClient.DownloadFile");
        }
        finally
        {
            client.Dispose();
        }
    }
}

