Console.WriteLine("Введите положительное целое число");
string? input = Console.ReadLine();
int number = Int32.Parse(input);

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
    Console.WriteLine("Третья цифра числа " + (number / 100) % 10);
}