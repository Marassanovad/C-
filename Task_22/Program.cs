// Задача 22: Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите число: ");
double x = Convert.ToDouble(Console.ReadLine());
double i= 1;
double b = 0;
if (x >= i){
    while(i <= x){
    b = Math.Pow(i, 2);
    i++ ;
    Console.WriteLine(b);}
}
else {
     Console.WriteLine("Невозможно");
 }



