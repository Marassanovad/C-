//Задача 14: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да

Console.WriteLine("введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int temp = number % 7;
int temp2 = number % 23;
if (temp == 0 & temp2 == 0)
{
    Console.WriteLine("кратно");
}
else{
    Console.Write("не кратно ");
}
