// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите несколько чисел через пробел");
string? input = Console.ReadLine();
string[] strArray = input.Split(' ');
int size = strArray.Length;

int Counter (string[] array)
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (int.Parse(strArray[i]) > 0)
        {
            count++;
        } 
    }
    return count;
}

Console.WriteLine("Количество положительных чисел = " + Counter(strArray));