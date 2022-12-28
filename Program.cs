Console.Write("Введите значение x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

Console.WriteLine($"Расстояние между точками: {d:f2}");