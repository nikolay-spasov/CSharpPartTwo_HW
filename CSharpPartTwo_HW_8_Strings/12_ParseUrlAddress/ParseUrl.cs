using System;

class ParseUrl
{
    static void Main()
    {
        //string urlString = "http://www.devbg.org/forum/index.php";

        Console.WriteLine("Enter url: ");
        string urlString = Console.ReadLine();

        string protocol = "";

        foreach (var ch in urlString)
        {
            if (ch == ':')
            {
                break;
            }
            protocol += ch;
        }

        urlString = urlString.Replace(protocol + "://", "");

        string server = "";
        foreach (var ch in urlString)
        {
            if (ch == '/')
            {
                break;
            }
            server += ch;
        }

        urlString = urlString.Replace(server, "");
        string resource = urlString;

        Console.WriteLine("[protocol] = \"{0}\"", protocol);
        Console.WriteLine("[server] = \"{0}\"", server);
        Console.WriteLine("[resource] = \"{0}\"", resource);
    }
}

