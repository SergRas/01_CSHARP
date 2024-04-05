using System;

class Program
{
    static void Main()
    {
        string input = "Привет мир как дела";
        string output = ReverseWords(input);
        
        Console.WriteLine(output);
    }
    
    static string ReverseWords(string input)
    {
        string[] words = input.Split(' ');
        Array.Reverse(words);
        
        return string.Join(" ", words);
    }
}