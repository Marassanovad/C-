// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Введите длину массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
int k = 0;
for (int i = 0; i < a; i++)
{
    Console.Write("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0)
    {
        k++;
    }
}
Console.WriteLine($"массив: {string.Join(", ", array)}");
Console.WriteLine($"Чисел больше нуля: {k}");


