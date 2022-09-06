//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите размер прямоугольного двумерного массива");
int m = Int32.Parse(Console.ReadLine());

int[,] array = new int[m, m];

int[,] FillArrayRandom (int m)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
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
        for (int j = 0; j < m; j++)
        {
            Console.Write(array[i, j] + " ");
        }
    Console.WriteLine();
    }
}

void MinRowSum (int[,] array)
{
    int[] sumRow = new int[m];
    int sum = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            sum = sum + array[i, j];
        }
    sumRow[i] = sum;
    sum = 0;
    }
    int temp = sumRow[0];
    int index = 0;
    for (int i = 1; i < m; i++)
    {
        if (sumRow[i] < temp)
        {
            temp = sumRow[i];
            index = i;
        }
    }
    Console.WriteLine("Номер строки с наименьшей суммой элементов = " + index);
}

PrintArray(FillArrayRandom(m));
MinRowSum(array);
