Console.WriteLine("Введите первое число");
string? input = Console.ReadLine();
int numberA = Int32.Parse(input);
Console.WriteLine("Введите второе число");
input = Console.ReadLine();
int numberB = Int32.Parse(input);
Console.WriteLine("Введите третье число");
input = Console.ReadLine();
int numberC = Int32.Parse(input);
int max = numberA;
if (numberB > max)
{
    max = numberB;
}
if (numberC > max)
{
    max = numberC;
}
Console.WriteLine("Максимальное из введенных чисел = " + max);