using System;

class Program
{
    static void Main()
    {
        int[,] numbers = new int[,] {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12}
        };

        int x = 2;
        int y = 2;

        int numRows = numbers.GetLength(0);
        int numCols = numbers.GetLength(1);

        if (x >= 1 && x <= numRows && y >= 1 && y <= numCols)
        {
            Console.WriteLine("Значение элемента в позиции ({0},{1}) равно {2}", x, y, numbers[x-1, y-1]);
        }
        else if (x < 1 || x > numRows)
        {
            Console.WriteLine("Позиция по рядам выходит за пределы массива");
        }
        else
        {
            Console.WriteLine("Позиция по колонкам выходит за пределы массива");
        }
    }
}