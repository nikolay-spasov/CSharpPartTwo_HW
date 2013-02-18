using System;
using System.IO;
using System.Text;

class ExtractTextFromXML
{
    private const string XML_FILE = "../../xmlFile.xml";

    static void Main()
    {
        //string xml = 
        //    @"<?xml version=""1.0""><student><name>Pesho</name><age>21</age><interests count=""3""><interest>Games</instrest><interest>C#</instrest><interest>Java</instrest></interests></student>";

        string xml = "";

        using (StreamReader reader = new StreamReader(XML_FILE))
        {
            xml = reader.ReadToEnd();
        }

        xml = xml.Replace(Environment.NewLine, "");
        xml = xml.Replace("\t", "");

        bool isTagOpened = false;

        StringBuilder builder = new StringBuilder();

        foreach (var ch in xml)
        {
            if (ch == '<')
            {
                isTagOpened = true;
            }
            else if (isTagOpened && ch == '>')
            {
                isTagOpened = false;
                builder.Append(" ");
            }
            else if (!isTagOpened)
            {
                builder.Append(ch);
            }
        }

        Console.WriteLine(builder.ToString().Trim());
    }
}

