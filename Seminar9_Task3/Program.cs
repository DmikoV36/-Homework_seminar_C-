// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите неотрицательное число M");
int m = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите неотрицптельное число N");
int n = Int32.Parse(Console.ReadLine());

int? Ackerman (int? m, int? n)
{
    if (m == 0) return n + 1;
    else if ((m > 0) && (n == 0)) return Ackerman(m - 1, 1);
    else if ((m > 0) && (n > 0)) return Ackerman(m - 1, Ackerman(m, n - 1));
    else return null;
}

Console.WriteLine ("Значение функции Аккермана при заданных параметрах = " + Ackerman(m, n));