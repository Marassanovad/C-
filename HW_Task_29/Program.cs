// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("");
int [] a = new int[8];
for(int i = 0; i < a.Length; i++) {
    Console.Write("Введите число: ");
    a[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Массив: [{string.Join(", ", a)}]");