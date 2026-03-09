using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(string[] args)
    {
        string input = @"Miller, John (2020)
Smith, Anna (2019)
Invalid Citation
Brown, David (2021)";

        int result = CountValidCitations(input);

        Console.WriteLine($"Valid citations: {result}");
        Console.ReadKey();
    }

    public static int CountValidCitations(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            throw new ArgumentException("Input cannot be empty.");

        int count = 0;

        string[] lines = text.Split(
            new[] { '\n' },
            StringSplitOptions.RemoveEmptyEntries
        );

        // Pattern: Lastname, Firstname (Year)
        string pattern = @"^[A-Z][a-zA-Z]*, [A-Z][a-zA-Z]* \([0-9]{4}\)$";

        foreach (string line in lines)
        {
            string trimmed = line.Trim();

            if (Regex.IsMatch(trimmed, pattern))
            {
                count++;
            }
        }

        return count;
    }
}