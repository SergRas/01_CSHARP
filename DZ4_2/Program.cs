using System;

partial class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int[] array = new int[10]; // Задаем размер массива

        // Заполняем массив случайными трехзначными числами
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(100, 1000); // Генерируем трехзначные числа
        }

        Console.WriteLine("Сгенерированный массив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        int count = CountEvenNumbers(array);
        Console.WriteLine($"Количество четных чисел в массиве: {count}");
    }

    static int CountEvenNumbers(int[] array)
    {
        int count = 0;
        foreach (int num in array)
        {
            if (num % 2 == 0) // Проверяем, является ли число четным
            {
                count++;
            }
        }
        return count;
    }
}