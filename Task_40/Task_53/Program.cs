// Задача 53: Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.


int[,] ourMatrix = GetMatrix(3,4,-10,10);
PrintMatrix(ourMatrix);
Console.WriteLine();
Reverse(ourMatrix);
PrintMatrix(ourMatrix);


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
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Reverse(int[,] matrix)
{
    
    int[] firstRows = new int [matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++){
        firstRows[i]= matrix[0,i];
        matrix[0, i] =matrix[matrix.GetLength(0)-1,i];
        matrix[matrix.GetLength(0)-1,i] =firstRows[i];
    }
}