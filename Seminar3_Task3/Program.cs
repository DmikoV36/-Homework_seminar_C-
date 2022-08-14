void CubeValue (int n)
{
    if (n < 0)
    {
       for (int i = -1; i >= n; i--)
        {
            Console.Write(Math.Pow(i, 3) + " ");
        } 
    }
    else if (n > 0)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.Write(Math.Pow(i, 3) + " ");
        }
    }
    
}

Console.WriteLine("Введите число");
int n = Int32.Parse(Console.ReadLine());
CubeValue(n);
