﻿//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет


Console.Write("Введите число от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());
string [] day = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday","Sunday"};

if (a == 6 | a == 7){
    Console.Write($"Да, это {day[a-1]}"); 
}
else if (a < 6 & a > 0) {
    Console.Write($"Нет, это {day[a-1]}");    
}   
else   { 
    Console.Write("Неправильное число");
}