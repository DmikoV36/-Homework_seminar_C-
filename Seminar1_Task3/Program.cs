Console.WriteLine("Введите число");
string? input = Console.ReadLine();
int number = Int32.Parse(input);
if (number % 2 == 0)
{
    Console.WriteLine("Число " + number + " является четным.");
}
else
{
    Console.WriteLine("Число " + number + " не является четным.");
}
