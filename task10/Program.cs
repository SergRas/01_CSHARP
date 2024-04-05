using System;

class Program
{
    static void Main()
    {
        string inputString = "бадденШалАш"; // Введите вашу произвольную строку здесь
        bool isPalindrome = CheckPalindrome(inputString);

        Console.WriteLine("Проверяемая строка: " + inputString);

        if (isPalindrome)
        {
            Console.WriteLine("Строка является палиндромом.");
        }
        else
        {
            Console.WriteLine("Строка не является палиндромом.");
        }
    }

    static bool CheckPalindrome(string input)
    {
        string cleanString = "";
        foreach (char c in input)
        {
            if (char.IsLetter(c)) // Игнорируем все символы, не являющиеся буквами
            {
                cleanString += char.ToLower(c); // Приводим буквы к нижнему регистру
            }
        }

        int left = 0;
        int right = cleanString.Length - 1;

        while (left < right)
        {
            if (cleanString[left] != cleanString[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}