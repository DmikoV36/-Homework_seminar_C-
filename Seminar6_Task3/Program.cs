// Доп. задча: Задайте двумерный массив со случайными числами от -10 до 10. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)

Console.WriteLine ("Введите количество строк массива");
int row = Int32.Parse(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов массива");
int column = Int32.Parse(Console.ReadLine());

int[,] array = new int[row, column];

void FillArray (int [,] array)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(-10, 11);
        }
    }
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write(array[i, j] + " ");
        }
    Console.WriteLine();
    }
}

int SumGeneralDiagonal (int[,] array)
{
    int sum = 0;
    int minSize = column;
    if (minSize > row)
    {
        minSize = row;
    }
    for (int i = 0; i < minSize; i++)
    {
        sum = sum + array[i, i];
    }
    return sum;
}

FillArray(array);
PrintArray(array);
Console.WriteLine("Сумма элементов, находящихся на главной диагонали = " + SumGeneralDiagonal(array));