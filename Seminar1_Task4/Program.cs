Console.WriteLine("Введите положительное целое число");
string? input = Console.ReadLine();
int number = Int32.Parse(input);
if (number < 1)
{
    while (number < 1)
    {
        Console.WriteLine("Вы ввели отрицательное число или 0");
        Console.WriteLine("Введите положительное целое число");
        input = Console.ReadLine();
        number = Int32.Parse(input);
    }
}

if (number == 1)
{
    Console.WriteLine("Вы ввели число 1. Четных чисел до 1 не существует!");
}
else
{
    int count = 2;
    Console.WriteLine("Все четные число до " + number);
    while (count <= number)
    {
        Console.WriteLine(count);
        count += 2;
    }
}