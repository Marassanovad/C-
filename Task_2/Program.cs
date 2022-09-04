//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//	3 -> Среда 
//5 -> Пятница

Console.Write("Введите число от 1 до 7:");
int a = Convert.ToInt32(Console.ReadLine());
if(0< a & a < 8){
   
    if(a == 1) {
        Console.Write("Monday");}
    if(a == 2) {
        Console.Write("Tuesday");}
    if(a == 3) {
        Console.Write("Wednesday");}
    if(a == 4) {
        Console.Write("Thuesday");}
    if(a == 5) {
        Console.Write("Friday");}
    if(a == 6) { 
        Console.Write("Saturday");}
    if(a == 7) {
        Console.Write("Sunday");}
}
else{ Console.Write("Неправильное число");}
