﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29


Console.Write("Введите число M: ");
double a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
double b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число аккермана равно: {Akkermen(b,a)}");


double Akkermen(double m,double n)
{    
    if(m==0) return n+1;
    else if(m>0 && n == 0) return Akkermen(m-1,1);
    else return Akkermen(m-1,Akkermen(m,n-1));

}


