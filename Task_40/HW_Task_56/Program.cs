// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
//и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] ourMatrix = GetMatrix(3, 3, 0, 10);
PrintMatrix(ourMatrix);
Console.WriteLine();
int minSumLine = 0;
int sumLine = SumLineEl(ourMatrix , 0);
for (int i = 1; i < ourMatrix.GetLength(0); i++)
{
  int NextSumLine = SumLineEl(ourMatrix, i);
  if (sumLine > NextSumLine)
  {
    sumLine = NextSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"Cтрокa с наименьшей суммой элементов: {minSumLine+1}");


int SumLineEl(int[,] matrix, int i)
{
  int sumLine = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    sumLine += matrix[i,j];
  }
  return sumLine;
}
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

