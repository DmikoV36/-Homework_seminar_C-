string[] array = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
Console.WriteLine("Введите цифру дня недели.");
string? input = Console.ReadLine();
int number = Int32.Parse(input);
if (number > 7 || number < 1)
{
    Console.WriteLine("Такого дня недели не существует!");
}
else
{
    if (number > 5)
    {
        Console.WriteLine(array[number -1] + " является выходным днем."); 
    }
    else
    {
        Console.WriteLine(array[number -1] + " это не выходной.");
    }
}
