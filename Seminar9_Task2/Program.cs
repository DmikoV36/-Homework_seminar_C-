// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число M");
int m = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите натуральное число N");
int n = Int32.Parse(Console.ReadLine());

if (m > n)
{
    int temp = m;
    m = n;
    n = temp;
}

int SumRec (int m, int n)
{
    if (m < n) return m + SumRec(m + 1, n);
    else return m;
}

Console.WriteLine("Сумма натуральных элементов в промежутке от M до N = " + SumRec(m, n));