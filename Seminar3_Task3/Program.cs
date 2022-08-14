void CubeValue (int n)
{
    for (int i = 1; i <= Math.Abs(n); i++)
    {
        Console.Write(Math.Pow(i, 3) + " ");
    }
}

Console.WriteLine("Введите число");
int n = Int32.Parse(Console.ReadLine());
CubeValue(n);
