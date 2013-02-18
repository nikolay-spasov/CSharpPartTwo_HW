using System;
using System.Globalization;
using System.Text.RegularExpressions;

class ExtractAllDates
{
    static void Main()
    {
        //string text = "Some stupid text and 01.12.1999 some dates here and there " + 
        //    "blah blah invalid date 55.38.1666 and a valid one 08.03.2020";

        string text = Console.ReadLine();

        string pattern = @"\b[0-9]{2}.[0-9]{2}.[0-9]{4}\b";

        CultureInfo cultureInfo = new CultureInfo("en-CA");
        var matches = Regex.Matches(text, pattern);
        foreach (Match m in matches)
        {
            DateTime date;
            if (DateTime.TryParse(m.Value, out date))
            {
                Console.WriteLine(date.ToString(cultureInfo));
            }
        }
    }
}

