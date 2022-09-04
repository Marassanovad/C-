//Задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
//5, 25 -> да
//-4, 16 -> да
//25, 5 -> да
//8,9 -> нет
Console.WriteLine("введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int min = number1;
int max = number2;
if (number1 > number2){
    min = number2;
    max = number1;
}
int kvad= min * min;
if (kvad == max){
       Console.WriteLine("Да");
}
else {
    Console.WriteLine("Нет");
}