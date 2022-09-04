// Задача 32: Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные,
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
int[] array = new int [12];
int[] array2 = new int [12];
Random rand = new Random();
for (int i = 0 ; i< array.Length; i ++) {
    array[i] = rand.Next (-9, 10);
    array2[i] = array[i] * -1;
}
Console.WriteLine($"Начальный массив:[{string.Join(", ", array)}]"); // написать массив
Console.WriteLine($"Измененный массив:[{string.Join(", ", array2)}]"); // написать массив наоборот


