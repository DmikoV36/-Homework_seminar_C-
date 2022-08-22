Console.WriteLine ("Введите количество элементов массива");
int n = Int32.Parse(Console.ReadLine());
int[] array = new int[n];

void InputArray (int[] array)
{
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < n - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[n-1] + "]");
}

InputArray (array);
PrintArray (array);