//Создание массива из 10 чисел. Вывод на экран четных чисел.

int n = 10;
int[] array = {1,2,4,6,7,9,5,6,8,3};
int i = 0;

while(i < n)
{
    if(array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i +1;
}