// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine("Введите количество элементов первой размерности");
int m = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите количество элементов второй размерности");
int n = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите количество элементов третьей размерности");
int o = Int32.Parse(Console.ReadLine());

int[,,] array = new int[m, n, o];
List<int> numbers = new List<int>();
int temp;

int[,,] FillArrayRandom (int m, int n, int o)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for ( int k = 0; k < o; k++)
            {
                do
                {
                    temp = new Random().Next(10, 100);
                }
                while (numbers.Contains(temp));
                numbers.Add(temp);
                array[i, j, k] = temp;
            }
        }
    }
    return array;
}

void PrintArray (int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for ( int k = 0; k < o; k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

PrintArray(FillArrayRandom(m, n, o));