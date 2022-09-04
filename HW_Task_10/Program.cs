//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


Console.Write("Введите трёхзначное число: ");
string number = Convert.ToString(Console.ReadLine());
int Lenght = number.Length ;
if (Lenght<3){
    Console.WriteLine("Это число не подходит");
}
else   {
    char firstChar = number[1];
    Console.WriteLine(firstChar);
}
