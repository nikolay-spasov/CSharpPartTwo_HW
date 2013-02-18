using System;
using System.Text;

class Codec
{
    static void Main()
    {
        Console.WriteLine("Enter the string you want to encode: ");
        string inputString = Console.ReadLine();
        Console.WriteLine("Enter the cipher: ");
        string cipher = Console.ReadLine();

        string encoded = XorTwoStrings(inputString, cipher);
        Console.WriteLine("Encoded string: {0}", encoded);
        string decoded = XorTwoStrings(encoded, cipher);
        Console.WriteLine("Decoded string: {0}", decoded);
    }

    private static string XorTwoStrings(string text, string cipher)
    {
        StringBuilder result = new StringBuilder(text.Length);

        for (int i = 0; i < text.Length; i++)
        {
            ushort ch = (ushort)(text[i] ^ cipher[i % cipher.Length]);

            result.Append((char)ch);
        }

        return result.ToString();
    }
}

