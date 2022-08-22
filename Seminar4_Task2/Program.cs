void SumNumber (string input)
{
    int length = input.Length;
    int number = Int32.Parse(input);
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    Console.WriteLine("Сумма цифр равна " + Math.Abs(sum));    

}

Console.WriteLine("Введите целое число");
string? input = Console.ReadLine();

SumNumber (input);