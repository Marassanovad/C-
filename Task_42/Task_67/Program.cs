﻿// Задача 67: Напишите программу, которая будет
// принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(Sum(n));



int Sum(int number){
    if(number==0) return 0;
        return number % 10 +Sum(number/10);

 
}