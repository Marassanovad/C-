// Задача 50. Напишите программу, которая 
//на вход принимает позиции элемента 
//в двумерном массиве, 
//и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет


Console.WriteLine("Введите строчку");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите столбец");
int n = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
int a =rnd.Next(3,7);
int b =rnd.Next(3,7);
int[,] ourMatrix = GetMatrix(3,4,0,10);
PrintMatrix(ourMatrix);
PrintNumber(ourMatrix, m,n);
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

void PrintNumber(int[,] matrix, int rowsCount, int columnsCount )
{
    if (matrix.GetLength(0)<= rowsCount-1 | matrix.GetLength(1)<= columnsCount-1 | m<1 |n <1) {
      Console.WriteLine("Ваше число вышло за пределы массива");  
    }
    
    else {
        Console.WriteLine($"Ваша число равно: {matrix[rowsCount-1, columnsCount-1]}"); 
    }
}