// Про координаты доделала



Console.Write("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0 ) {
    Console.WriteLine("Координата находиться в 1 четверти");
}
else if (x < 0 && y > 0 ) {
    Console.WriteLine("Координата находиться в 2 четверти");
}
else if (x < 0 && y < 0 ) {
    Console.WriteLine("Координата находиться в 3 четверти");
}
else if (x > 0 && y < 0 ) {
    Console.WriteLine("Координата находиться в 4 четверти");
}
else {
    Console.WriteLine("Невозможно определить");
}