// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] arr = {6, 7, 3, 6}; //исходный массив

int newLength = arr.Length / 2 + arr.Length % 2;

int[] resultArr = new int[newLength];

for (int i = 0; i < newLength; i++) {
    resultArr[i] = arr[i] * arr[arr.Length - 1 - i];
}

if (arr.Length % 2 == 1) {
   resultArr[resultArr.Length - 1] = arr[arr.Length / 2];
}
Console.WriteLine(string.Join(", ", resultArr)); //выводим результирующий массив

// Random rand = new Random();
// Console.WriteLine("Введите длину массива:");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] array = new int [a];
// int d = a/2;
// int[] sum = new int [d+1];
// int e = array.Length-1;
// for (int i = 0 ; i< array.Length; i ++) {
//     array[i] = rand.Next (0, 10);
// }
// for (int f = 0; f < d; f++){
//    sum[f] = array[f] * array[e];
//    e = e-1;
// }

// Console.WriteLine($"массив:[{string.Join(", ", array)}]");
// Console.WriteLine($"массив:[{string.Join(", ", sum)}]");

