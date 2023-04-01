Console.Write("Ввведите k1");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввведите b1");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввведите k2");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввведите b2");
double b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2)
{
    Console.WriteLine("Прямые паралельны, нет точки пересечения");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
}
Console.WriteLine($"Точка пересеченлия :({x},{y})");



