//Создание массива из 10 элементов и его заполнение
int n = 10;
int[] arr = new int[n];
int i = 0;

while (i < n)
{
    arr[i] = i + 1;
    //Console.Write(arr[i]);
    //Console.Write(' ');
    Console.Write($"{arr[i]} ");
    i = i + 1;
}