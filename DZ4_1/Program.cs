using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите целое число или символ 'q' для выхода:");
            string input = Console.ReadLine();

            // Проверяем, является ли введенное значение 'q' для выхода из цикла
            if (input == "q")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            // Пытаемся преобразовать введенное значение в целое число
            if (int.TryParse(input, out int number))
            {
                // Проверяем, является ли сумма цифр числа четной
                if (IsEvenDigitSum(number))
                {
                    Console.WriteLine("Сумма цифр числа четная. Программа завершена.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Неверный формат числа. Повторите ввод.");
            }
        }
    }

    static bool IsEvenDigitSum(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum % 2 == 0;
    }
}