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
            array[i, j] = new Random().Next(0, 100);
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

Console.WriteLine("Введите искомое число");
int number = Int32.Parse(Console.ReadLine());

void SearchNumber (int number)
{
   for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (array[i, j] == number)
            {
                Console.WriteLine($"Искомое число имеет координаты ({i}, {j})");
                return;
            }
        }
    }
    Console.WriteLine("Такого числа в массиве нет."); 
}

SearchNumber(number);