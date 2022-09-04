// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] array = {3,7,22,0,70};
double min = array[1];
double max = array[1];
double raz =0;
for (int i = 0 ; i< array.Length; i ++) {
    if (min > array[i]) {
        min = array[i];
    }
    else if (max < array[i]) {
        max = array[i];
    }
    
}
raz = max- min;
Console.WriteLine($"массив:[{string.Join(", ", array)}]");
Console.WriteLine($"разницу между максимальным и минимальным элементов массива: {raz}");
