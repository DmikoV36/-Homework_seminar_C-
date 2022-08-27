Console.WriteLine("Ввелите количество строк в массиве");
int m = Int32.Parse(Console.ReadLine());
Console.WriteLine("Ввелите количество столбцов в массиве");
int n = Int32.Parse(Console.ReadLine());

int[,] array = new int[m, n];

int[,] FillArrayRandom (int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray (int[,] array)
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

PrintArray(FillArrayRandom(m, n));

void ArithmeticMean (int[,] array)
{
    double sum = 0;
    for (int j = 0; j < n; j++)
    {
        for (int i = 0; i < m; i++)
        {
            sum = sum + array[i, j];
        }
    Console.WriteLine($"Среднее знечение столбца с индексом {j} равно {Math.Round((sum / m), 2)}");
    sum = 0;
    }
}

ArithmeticMean(array);