//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Введите количество строк в массиве");
int m = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве");
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

int[,] SortRowArray (int[,] array)
{
    int temp = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < n - 1; k++)
            {
                if (array[i,k] < array[i, k + 1])
                {
                    temp = array[i,k];
                    array[i,k] = array[i,k + 1];
                    array[i,k + 1] = temp;
                }
            }
        }
    }
    return array;
}

PrintArray(FillArrayRandom(m, n));
Console.WriteLine("Упорядоченный массив");
SortRowArray(array);
PrintArray(array);