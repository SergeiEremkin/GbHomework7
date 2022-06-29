int [,] CreateArray (int n, int m)
{
 return new int [n,m];
}

void FillArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}    

void ColumnGradePointAverage(int[,] array)
{
    double SumColumnElements  = 0; 
    double GradePointAverage = 0;
    
    for (int i = 0; i < array.GetLength(1); i++)
    {     
        for (int j = 0; j < array.GetLength(0); j++)
        {
            SumColumnElements =(SumColumnElements + array[j,i]);
        }
        GradePointAverage = Math.Round(SumColumnElements/array.GetLength(0),1);
        System.Console.Write($"{GradePointAverage}; ");
        SumColumnElements =0;
    }
    
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  "); 
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
int[,] arr = CreateArray(3,4);
FillArray(arr);
PrintArray(arr);
ColumnGradePointAverage(arr);