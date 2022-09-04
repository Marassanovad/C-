// Задача 55: Задайте двумерный массив. 
//Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение 
//для пользователя.


int[,] ourMatrix = GetMatrix(4, 3, -10, 10);
PrintMatrix(ourMatrix);
Console.WriteLine();
Reverse(ourMatrix);



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

    int[,] firstRows = new int[matrix.GetLength(1), matrix.GetLength(0)];


    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            firstRows[i, j] = matrix[j, i];
            Console.Write(firstRows[i, j] + " ");
        }
        Console.WriteLine();
    }

}





