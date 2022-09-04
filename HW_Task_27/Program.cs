
// Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int n = number;
int sum = 0;
int ost = 0;
number = Math.Abs(number);
// if(number < 0){
//     number = -1* number;
// }
for(int max = 1; number > max; max= max *10){
    
    ost = n % 10;
    n= n / 10;
    sum = sum + ost;
}
if (sum < 0){
    sum = -1 * sum;
}
Console.WriteLine($"Сумма всех цифр: {sum}");

