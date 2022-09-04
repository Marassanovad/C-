// Задача 33: Задайте массив. 
//Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
// Выводить сообщение "да" или "нет" ТОЛЬКО ОДИН РАЗ

int[] array = new int [12];
Random rand = new Random();
Console.Write("Введите число для поиска:");
int need = Convert.ToInt32(Console.ReadLine());
 int d = 0;
for (int i = 0 ; i< array.Length; i ++) {
    array[i] = rand.Next (0, 10);
if (array[i]== need){
        d = need;
    }
}
Console.WriteLine($"массив:[{string.Join(", ", array)}]");
if ( d == need) {
    Console.WriteLine("yes");
}
else {
    Console.WriteLine("no");
}









