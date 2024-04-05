//  Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от 1 до N.

string Len(int stop, int start = 1)
{
    if(start == stop) return Convert.ToString(stop);
    return start + " " + Len(stop, start + 1);
}

void Len2(int num)
{
    if(num == 0) return;
    Len2(num -1);
    Console.Write($"{num} ");
}

void Len3(int num)
{
    if(num == 0) return;
    Console.Write($"{num} ");
    Len3(num -1);
    
}

Console.WriteLine("ВВедите число ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Len(n));
Len2(n);
Len3(n);