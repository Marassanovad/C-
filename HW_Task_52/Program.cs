// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

Console.WriteLine("Введите кол-во строчек");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] ourMatrix = GetMatrix(m,n,0,10);
PrintMatrix(ourMatrix);
Console.WriteLine();
ArNumber(ourMatrix);

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange);
        }
    }

    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ArNumber(int[,] matrix)
{   
    for (int i = 0; i < matrix.GetLength(1); i++)
    {   int a = 0;
        double b = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
        
        a = a+matrix[j,i]; 
        }
        
        b =(double)a/ matrix.GetLength(0);
        Console.WriteLine($"{b:f2} ");    
    }

}