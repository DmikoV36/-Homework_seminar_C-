double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return dist;
}

Console.WriteLine("Введите координату x первого числа");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y первого числа");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z первого числа");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату x второго числа");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y второго числа");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z второго числа");
double z2 = double.Parse(Console.ReadLine());

Console.WriteLine("Расстояние между точками = " + Distance(x1, y1, z1, x2, y2, z2));