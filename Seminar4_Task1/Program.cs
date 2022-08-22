int exp = 1;
int Exponentiation (int a, int b)
{
    for (int i = 1; i <= b; i++)
    {
        exp = exp * a;
    }
    return exp;
}

Console.WriteLine ("Введите число А");
int a = Int32.Parse(Console.ReadLine());
Console.WriteLine ("Введите число В");
int b = Int32.Parse(Console.ReadLine());

Exponentiation(a, b);
Console.WriteLine ("Число А в степени В равно " + exp);
