//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


//Console.Write("Введите трёхзначное число: ");
//string number = Convert.ToString(Console.ReadLine());
//int Lenght = number.Length ;
//if (Lenght<3){
    //Console.WriteLine("Третьей цифры нет");
//}
//else   {
   // char firstChar = number[2];
   // Console.WriteLine(firstChar);
//}

Console.WriteLine("Введите число");
string number = Console.ReadLine();
int digitIndex = 2;
if (number[0] == '-'){
    digitIndex ++;
}
if (number.Length > digitIndex)
{
Console.WriteLine(number[digitIndex]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

