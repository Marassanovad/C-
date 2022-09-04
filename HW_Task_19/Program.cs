//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
           
int old = number;
int new1 = 0;
while (number > 0) {
    int a = number % 10;
    new1 = new1 * 10 + a;
    number = number / 10;
}
if (new1 == old) {
    Console.WriteLine("Число является палиндромом");
}
else{
    Console.WriteLine("Число не является палиндромом");
}



 

