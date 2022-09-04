// Задача 59: Задайте двумерный массив из целых чисел. 
//Напишите программу, которая удалит строку и столбец, на пересечении 
//которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int[,] ourMatrix = GetMatrix(3, 3, 0, 10);
PrintMatrix(ourMatrix);
Console.WriteLine();
ChangeMassiv(ourMatrix);




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

void ChangeMassiv(int[,] matrix)
{
    
    int [] minIndex = new int[2];
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

