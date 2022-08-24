Console.WriteLine ("Введите количество элементов массива");
int n = Int32.Parse(Console.ReadLine());
double[] array = new double[n];

void InputArray (double[] array)
{
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(-99, 100) + new Random().NextDouble();
    }
    Console.WriteLine(string.Join(", ", array));
}

void Difference (double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < n; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    Console.WriteLine ("Разница между максимальным и минимальным элементами массива =" + (max - min));
}

InputArray (array);
Difference (array);