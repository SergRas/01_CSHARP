using System;

class Program
{
    static void Main()
    {
        char[,] charArray = new char[,]
        {
            { 'H', 'e', 'l', 'l', 'o' },
            { 'W', 'o', 'r', 'l', 'd' }
        };

        Console.WriteLine("Исходный массив символов:");

        PrintCharArray(charArray);

        string resultString = GetStringFromArray(charArray);

        Console.WriteLine("\nСтрока, созданная из символов массива:");
        Console.WriteLine(resultString);
    }

    static void PrintCharArray(char[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j]);
            }
            Console.WriteLine();
        }
    }

    static string GetStringFromArray(char[,] array)
    {
        string result = "";

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                result += array[i, j];
            }
        }

        return result;
    }
}