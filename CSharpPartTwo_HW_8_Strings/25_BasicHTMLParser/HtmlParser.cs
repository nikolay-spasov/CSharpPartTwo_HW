using System;
using System.Text;

class HtmlParser
{
    static void Main()
    {
        string htmlText =
            "<html>" +
            "<head>" +
            "<title>News</title>" +
            "</head>" +
            "<body>" +
            "<p>" +
            @"<a href=""http://academy.telerik.com"">" +
            "Telerik Academy" +
            "</a>" +
            "aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers." +
            "</p>" +
            "</body>" +
            "</html>";

        string title = GetTitle(htmlText);
        string body = GetAllTextWithoutTags(htmlText);

        Console.WriteLine("Title: ");
        Console.WriteLine('\t' + title);
        Console.WriteLine("Body: ");
        Console.WriteLine('\t' + body);
    }

    private static string GetTitle(string htmlString)
    {
        string title = "";

        int titleStart = htmlString.IndexOf("<title>", 0);
        int titleEnd = htmlString.IndexOf("</title>", 0);

        if (titleStart != -1 && titleEnd != -1)
        {
            title = htmlString.Substring(titleStart + "<title>".Length,
                titleEnd - titleStart - "<title>".Length);
        }

        return title;
    }

    private static string GetAllTextWithoutTags(string htmlString)
    {
        StringBuilder builder = new StringBuilder();

        int startingIndex = htmlString.IndexOf("<body>");

        if (startingIndex == -1)
        {
            throw new ArgumentException(
                "Html string does not have a body tag.");
        }

        bool isTagOpened = false;

        for (int i = startingIndex; i < htmlString.Length; i++)
        {
            if (htmlString[i] == '<')
            {
                isTagOpened = true;
            }
            else if (htmlString[i] == '>' && isTagOpened)
            {
                isTagOpened = false;
                builder.Append(' ');
            }
            else if (!isTagOpened)
            {
                builder.Append(htmlString[i]);
            }
        }

        return builder.ToString().Trim();
    }
}

