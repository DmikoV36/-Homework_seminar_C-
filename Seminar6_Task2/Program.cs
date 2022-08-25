// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine ("Введите значение коэффициента b1");
double b1 = Int32.Parse(Console.ReadLine());
Console.WriteLine ("Введите значение коэффициента k1");
double k1 = Int32.Parse(Console.ReadLine());
Console.WriteLine ("Введите значение коэффициента b2");
double b2 = Int32.Parse(Console.ReadLine());
Console.WriteLine ("Введите значение коэффициента k2");
double k2 = Int32.Parse(Console.ReadLine());

void IntersectionPoint (double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k2 * b1 - k1 * b2) / (k2 - k1);
    
    Console.WriteLine($"Точка пересечения прямых y = {k1} * x + {b1} и y = {k2} * x + {b2} имеет координаты ({x:f2}; {y:f2})");
}

IntersectionPoint(b1, k1, b2, k2);