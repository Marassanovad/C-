// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите длину массива:");
int d = Convert.ToInt32(Console.ReadLine());
int[] array = new int [d];
Random rand = new Random();
int a =0;
for (int i = 0 ; i< array.Length; i ++) {
    array[i] = rand.Next (-100, 100);
    if (i%2 == 1){
       a = a+ array[i];
    }
}
Console.WriteLine($"массив:[{string.Join(", ", array)}]");
Console.WriteLine($"сумму элементов, стоящих на нечётных позициях: {a}");