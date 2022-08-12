Console.WriteLine("Введите положительное целое число");
string? input = Console.ReadLine();

if (input.Length < 3)
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
    Console.WriteLine("Третья цифра числа " + input[2]);
}