﻿// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов
//  в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма равна: {Sum(n,m)}");

int Sum(int a, int b)
{
      if(a >b) return 0;
      return a+Sum(a+1,b);
}

