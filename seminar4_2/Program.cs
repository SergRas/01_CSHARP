int[,] num1 = {{2, 32, 4, 3}, 
                {4, 3, 12, 1}, 
                {2, 8, 5, 4}};

 int[] Sum (int[,] num1)
 { int[] summa = new int [num1.GetLength(0)];
   
    for ( int i = 0; i < num1.GetLength(0); i++)
    { int sum = 0;

        for ( int j = 0; j < num1.GetLength(1); j++)
        {
            sum = sum + num1[i, j];
            
        }
         summa[i] = sum; 
    }
    return summa;
 }


void Print(int[] arr)
{
    for ( int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]}" );
    }
    Console.WriteLine();
} 


void Print2(double[] arr)
{
    for ( int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]}" );
    }
    Console.WriteLine();
}

double[] Middle (int[] a, int[,] b)
{
    double[] c = new double[b.GetLength(0)];
    for( int i = 0; i < a.Length; i++)
    {
       c[i] = Convert.ToDouble(a[i]) / Convert.ToDouble(b.GetLength(1));
    }
    return c;
}




int[] num2 = Sum(num1); // после всех циклов функции Sum вернулся одномерный массив  сохранен в этот массиве
Print(num2);

double[] num3 = Middle(num2, num1);
Print2(num3);