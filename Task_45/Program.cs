// Задача 45: Напишите программу,
// которая будет создавать копию заданного массива 
//с помощью поэлементного копирования.

Console.WriteLine("Введите длину массива");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int [a];
int[] array2 = new int [a];
Random rand = new Random();
for (int i = 0 ; i< array.Length; i ++) {
    array[i] = rand.Next (-9, 10);
    array2[i] = array[i];
}
Console.WriteLine($"Начальный массив:[{string.Join(", ", array)}]"); // написать массив
Console.WriteLine($"Копираванный массив:[{string.Join(", ", array2)}]"); // написать Копираванный массив 