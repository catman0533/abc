Console.WriteLine("Введите координаты точки a");
Console.Write("Введите координату xa:");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату ya:");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты za:");
int za = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координаты точки b");
Console.Write("Введите координату xb:");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату yb:");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты zb:");
int zb = Convert.ToInt32(Console.ReadLine());


double Leng = Distance(xa, ya, za, xb, yb, zb);
Console.WriteLine($"Растояние между точками a и b = {Math.Round(Leng, 2, MidpointRounding.ToZero)}");



double Distance( int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt((x2 - x1)*(x2 - x1)+ (y2 - y1)*(y2 - y1)+ (z2 - z1)*(z2 - z1));
}
   


