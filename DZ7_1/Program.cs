// Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N . Не использовать циклы,
// использовать рекурсию.

string Len(int start, int stop)
{
        if (start <= stop)
        {
            return start + " " + Len(start + 1, stop);
        }
        return "";
}
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Len(M, N));