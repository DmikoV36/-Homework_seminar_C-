Console.WriteLine("Введите первое число");
string? input = Console.ReadLine();
int numberA = Int32.Parse(input);
Console.WriteLine("Введите второе число");
input = Console.ReadLine();
int numberB = Int32.Parse(input);
if (numberA > numberB)
{
    Console.WriteLine("Число " + numberA + " больше, чем число " + numberB);
}
else if (numberA < numberB)
{
    Console.WriteLine("Число " + numberB + " больше, чем число " + numberA);
}
else Console.WriteLine("Оба числа равны.");