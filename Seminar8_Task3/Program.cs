// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Введите количество строк в первой матрице");
int m = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в первой матрице");
int n = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк во второй матрице");
int k = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов во второй матрице");
int l = Int32.Parse(Console.ReadLine());

if (n != k)
{
    Console.WriteLine("Эти матрицы умножать нельзя!");
    return;
}

int[,] array1 = new int[m, n];
int[,] array2 = new int[k, l];
int[,] mult = new int[m, l];

int[,] FillArrayRandom (int m, int n)
{
    int[,] array = new int[m, n];
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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
    Console.WriteLine();
    }
}

int[,] MatrixMultiplication (int[,] array1, int[,] array2)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < l; j++)
        {
            int temp = 0;
            for (int o = 0; o < n; o++)
            {
                temp = temp + array1[i, o] * array2[o,j];
            }
            mult[i,j] = temp;
        }
    }
    return mult;
}

array1 = FillArrayRandom(m, n);
Console.WriteLine("Первая матрица");
PrintArray(array1);
array2 = FillArrayRandom(k, l);
Console.WriteLine("Вторая матрица");
PrintArray(array2);
MatrixMultiplication(array1, array2);
Console.WriteLine("Результирующая матрица");
PrintArray(mult);