﻿// Задача 57: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9


int[,] ourMatrix = GetMatrix(3, 3, 0, 10);
PrintMatrix(ourMatrix);
Console.WriteLine();
countNumber(ourMatrix);



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

void countNumber(int[,] matrix)
{
    
    int[] repeats = new int[10];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           repeats[matrix[i,j]]++;
        }
        
    }
    for (int a = 0; a < repeats.Length; a++)
    if (repeats[a]> 0){
    Console.WriteLine($"Кол-во повторений числа {a} :{repeats[a]}");

    }
}

