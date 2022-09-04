//Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 

Console.Write("введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine()) ;
Console.Write("введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine()) ;
 if(number1 == number2 * number2) {
    Console.Write("Yes");
}
 else{
    Console.Write("No");
 } 