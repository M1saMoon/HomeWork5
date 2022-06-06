//Найти точку пересечения двух прямых заданных уравнением 
//y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Console.Clear();
Console.Write("Введите координату b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату b2: ");
int b2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату k2:");
int k2 = int.Parse(Console.ReadLine());
int x = (b2 - b1) / (k1 - k2);
int y = k2 * x + b2;
Console.WriteLine($"Точка пересечения x = {x}");
Console.WriteLine($"Точка пересечения y = {y}");

// y = k1 * x + b1    y = k2 * x + b2
// y-y = k1 * x + b1 - k2 * x + b2
// 0 = x * (k1 - k2) + b1 - b2
// x = (b2 - b1) / (k1 - k2)
// y = k2 * x + b2

