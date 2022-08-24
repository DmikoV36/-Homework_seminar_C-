Console.WriteLine ("Введите количество элементов массива");
int n = Int32.Parse(Console.ReadLine());
int[] array = new int[n];

void InputArray (int[] array)
{
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    Console.WriteLine(string.Join(", ", array));
}

void NumberOfEven (int n)
{
    int number = 0;
    for (int i = 0; i < n; i++)
    {
        if (array[i] % 2 == 0)
        {
            number += 1;
        }
    }
    Console.WriteLine ("Количество четных элементов массива = " + number);
}


InputArray (array);
NumberOfEven (n);
