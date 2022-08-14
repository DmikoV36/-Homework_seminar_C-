void polindrom(string number)
{
    if ((number[0] == number[4]) && (number[1] == number[3]))
    {
        Console.WriteLine("Введенное число является полиндромом!");
    }
    else
    {
        Console.WriteLine("Это не полиндром.");
    }

}

Console.WriteLine("Введите положительное пятизначное число");
string? number = Console.ReadLine();
int? numb = Int32.Parse(number);
if ((numb >= 100000) || (numb < 10000))
{
    while ((numb >= 100000) || (numb < 10000))
    {
        Console.WriteLine("Что-то пошло не так)");
        Console.WriteLine("Введите положительное пятизначное целое число");
        number = Console.ReadLine();
        numb = Int32.Parse(number);
    }
}

polindrom(number);