// Задача 44: Не используя рекурсию, 
//выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
//F n = F n − 1 + F n − 2 .
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("0 1 ");
Fib(n);

void Fib(int number){
int fib1 = 0;
int fib2 = 1;
int i = 0;
while (i < number - 2){
    int fib_sum = fib1 + fib2;
    fib1 = fib2;
    fib2 = fib_sum;
    i = i + 1;
  Console.Write($"{fib2} " );
    }
}

