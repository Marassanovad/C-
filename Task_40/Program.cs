// Задача 40: Напишите программу, которая принимает на вход 
//три числа и проверяет, может ли существовать треугольник 
//с сторонами такой длины.
// Теорема о неравенстве треугольника: 
//каждая сторона треугольника меньше суммы двух других сторон.

// int []array = new int[3];
//    for(int i = 0; i < array.Length; i++) {
//     Console.WriteLine("Введите число:");
//     array[i] = Convert.ToInt32(Console.ReadLine());
//    }


// if (array[1]<array[0]+array[2] && array[2]<array[0]+array[1] &&array[0]<array[1]+array[2]){
//    Console.WriteLine("существует");
// }
// else { Console.WriteLine("не существует");}

Console.WriteLine("Введите A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите B: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите C: ");
int C = Convert.ToInt32(Console.ReadLine());

//метод для вывода на консоль ответа с флажком
bool res = IsTriangleExist(A, B, C);
if (res == true) {
   Console.WriteLine("существует");
}
else {
   Console.WriteLine("не существует");
}


// метод поднятия флажка
bool IsTriangleExist(int a, int b, int c){ 
   bool isExist = false; // такой треугольник не существует
    
   if(a< b+c && b< a+c && c< a+b) {
      isExist = true; // такой треугольник может существовать
   }

   return isExist;
}




