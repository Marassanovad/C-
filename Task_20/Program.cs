// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

//AB = √(xb - xa)2 + (yb - ya)2 - расстояния координат в 2d пространстве
//Math.Sqrt() - корень
//Math.Pow(число, степень) - возвести в степень

Console.Write("Введите x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine($"AB = {distance}");



