// Задайте произвольный массив. Выведите
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

int[] array = { 1, 2, 5, 0, 10, 34 };
PrintArrRev(array, array.Length - 1);
		
void PrintArrRev(int[] arr, int i)
    {
        if (i >= 0)
        {
            Console.Write(arr [i] +" ");
            PrintArrRev(arr, i - 1);
        }
    }		