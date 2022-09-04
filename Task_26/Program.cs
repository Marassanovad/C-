// Задача 26: Напишите программу, которая принимает на вход число 
//и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 0){
    number = -1* number;
}
int a = 1;
for(int max = 10; number > max; max= max*10){
    a++;
}
Console.WriteLine($"Кол-во цифр: {a}");



