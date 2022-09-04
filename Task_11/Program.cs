//Задача 11: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

string number = Convert.ToString(new Random().Next(100,1000));
Console.WriteLine($"Наше рандомное число = {number}");
char firstChar = number[0];
char lastChar = number[2];
Console.WriteLine($"{firstChar}{lastChar}");



