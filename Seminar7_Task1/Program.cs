Console.WriteLine("Ввелите число m");
int m = Int32.Parse(Console.ReadLine());
Console.WriteLine("Ввелите число n");
int n = Int32.Parse(Console.ReadLine());

double[,] array = new double[m, n];

double[,] FillArrayRandomReal (int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-99, 100) + Math.Round(new Random().NextDouble(), 3);
        }
    }
    return array;
}
void PrintArray (double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + " ");
        }
    Console.WriteLine();
    }
}

PrintArray(FillArrayRandomReal(m, n));