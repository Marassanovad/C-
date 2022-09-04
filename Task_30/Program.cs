// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]



int[] c = new int[8];

int index = 0; 
while(index < 8){
    c[index] = new Random().Next(0,2);
    index++;
}
int position = 0 ;
 while(position< 8){
    Console.Write($"{c[position]}, ");
    position++;
}
