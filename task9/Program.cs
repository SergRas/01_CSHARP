using System;

class Program
{
    static void Main()
    {
        string originalString = "Hello World! How Are You?";
        string modifiedString = ConvertToLowerCase(originalString);

        Console.WriteLine("Исходная строка:");
        Console.WriteLine(originalString);

        Console.WriteLine("\nСтрока с заменой заглавных букв на строчные:");
        Console.WriteLine(modifiedString);
    }

    static string ConvertToLowerCase(string input)
    {
        string result = "";

        foreach (char c in input)
        {
            if (char.IsUpper(c))
            {
                result += char.ToLower(c);
            }
            else
            {
                result += c;
            }
        }

        return result;
    }
}
