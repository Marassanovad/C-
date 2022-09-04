// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// Доп. условие для 51 задачи: сделать суммирование в один цикл. Матрица может быть прямоугольный


Console.WriteLine("Введите кол-во строчек");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов");
int n = Convert.ToInt32(Console.ReadLine());

double[,] ourMatrix = GetMatrix(m, n, -10, 10);
PrintMatrix(ourMatrix);
Diognalic(ourMatrix);

double[,] GetMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
    double[,] matrix = new double[rowsCount, columnsCount];

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
void PrintMatrix(double[,] matrix)
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
void Diognalic(double[,] matrix)
{
    double b = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {   int j = matrix.GetLength(1);
        if(i<j){
            int k = i;
            b = b+ matrix[i,k];
        }
    }
    Console.WriteLine($"Сумма элементов главной диагонали: {b}");
}

