// Доп. задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

Console.WriteLine("Введите количество строк в массиве");
int m = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве");
int n = Int32.Parse(Console.ReadLine());

int[,] array = new int[m, n];
int counter = 1;
int step = 0;

int[,] SpiralArray(int m, int n)
{
    while (counter <= m * n)
    {
        for (int i = step; i < n - step; i++)
        {
            array[step, i] = counter;
            counter++;
            if (counter >= m * n) break;
        }
        for (int j = step + 1; j < m - step - 1; j++)
        {
            array[j, n - step - 1] = counter;
            counter++;
            if (counter >= m * n) break;
        }
        for (int i = n - step - 1; i > step; i--)
        {
            array[m - step - 1, i] = counter;
            counter++;
            if (counter >= m * n) break;
        }
        for (int j = m - step - 1; j > step; j--)
        {
            array[j, step] = counter;
            counter++;
            if (counter >= m * n) break;
        }
        step++;
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]:D2} ");
        }
        Console.WriteLine();
    }
}

SpiralArray(m, n);
PrintArray(array);
