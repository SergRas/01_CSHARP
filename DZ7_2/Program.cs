// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// Из Википедии:
// В псевдокоде функция Аккермана реализуется по определению:

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//     вернуть ack(n - 1, ack (n, m - 1))


Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = Ack(m, n);
Console.WriteLine($"Результат функции Аккермана для чисел {m} и {n} = {result}");

int Ack(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ack(m - 1, 1);
        }
        else
        {
            return Ack(m - 1, Ack(m, n - 1));
        }
    }