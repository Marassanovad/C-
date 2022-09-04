Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
// int i = 1;
int sum = 0;
if (number < 1){
    Console.WriteLine("Неправильное число");
}
else{
for(int i = 1;i<= number; i++){
 sum = sum+ i;
}
Console.WriteLine($"Сумма чисел от 1  до N: {sum}");
}
