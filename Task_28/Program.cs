// Задача 28: Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 1;
if (number < 1){
    Console.WriteLine("Неправильное число");
}
else{
for(int i = 1;i<= number; i++){
 sum = sum * i;
}
Console.WriteLine($"Произведение чисел от 1 до N: {sum}");
}
