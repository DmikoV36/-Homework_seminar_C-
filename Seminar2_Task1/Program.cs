Console.WriteLine("Введите положительное трехзначное целое число");
string? input = Console.ReadLine();
int number = Int32.Parse(input);
if (number >= 1000 || number < 100)
{
    while (number >= 1000 || number < 100)
    {
        Console.WriteLine("Что-то пошло не так)");
        Console.WriteLine("Введите положительное трехзначное целое число");
        input = Console.ReadLine();
        number = Int32.Parse(input);
    }
}

Console.WriteLine("Вторая цифра числа " + (number / 10) % 10);