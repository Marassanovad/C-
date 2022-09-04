//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int x = 2; x <= number; x++)       
if (x%2==0)            
Console.Write($" {x}");
