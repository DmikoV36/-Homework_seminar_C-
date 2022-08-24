Console.WriteLine ("Введите количество элементов массива");
int n = Int32.Parse(Console.ReadLine());
int[] array = new int[n];

void InputArray (int[] array)
{
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
    Console.WriteLine(string.Join(", ", array));
}

void SumOddIndex (int[] array)
{
    int sum = 0;
    for (int i = 1; i < n; i += 2)
    {
        sum = sum + array[i];
    }
    Console.WriteLine("Сумма элементов, стоящих на нечётных позициях = " + sum);
}

InputArray (array);
SumOddIndex (array);