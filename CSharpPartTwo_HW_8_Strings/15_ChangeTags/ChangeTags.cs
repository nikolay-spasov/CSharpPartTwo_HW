using System;

class ChangeTags
{
    static void Main()
    {
        string html = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";

        while (true)
        {
            int start = html.IndexOf("<a href=\"", 0);
            int end = 0;
            if (start != -1)
            {
                end = html.IndexOf(">", start);
            }

            if (start == -1 || end == -1)
            {
                break;
            }

            string sub = html.Substring(start, end - start + 1);
            string newSub = sub.Replace("<a href=\"", "[URL=");
            newSub = newSub.Replace(">", "]");

            html = html.Replace(sub, newSub);

            //Console.WriteLine(html.Substring(start, end - start + 1));
        }

        html = html.Replace("</a>", "[/URL]");

        Console.WriteLine(html);
    }
}

