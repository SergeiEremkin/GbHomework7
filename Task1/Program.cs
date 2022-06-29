double [,] CreateArray (int n, int m)
{
 return new double [n,m];
}

void FillRealNumbersArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Math.Round(new Random().NextDouble()*20-10, 2);
        }
    }
}

void PrintArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  "); 
        }
        System.Console.WriteLine();
    }
}
double[,] arr = CreateArray(3,4);
FillRealNumbersArray(arr);
PrintArray(arr);
