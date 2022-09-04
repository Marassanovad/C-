//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


Console.Write("Введите число: ");
double x = Convert.ToDouble(Console.ReadLine());
double i= 1;
double b = 0;
if (x >= i){
    while(i <= x){
    b = Math.Pow(i, 3);
    i++ ;
    Console.WriteLine(b);}
}
else {
     Console.WriteLine("Невозможно");
 }