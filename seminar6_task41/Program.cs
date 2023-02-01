// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

string SetOfNumbers (int number)
{
    int i = 0;
    int sum = 0;
    string result = string.Empty;
    while (number > i)
    {
        Console.WriteLine("Введите число");
        int num = int.Parse(Console.ReadLine()!);
        if (num > 0)
        {
            sum = sum + 1;
        }
        else
        {
            sum = sum + 0;
        }
        i++;
        if (i < number)
        {
            result = ($"{result} {num} ,");
        }
        else
        {
            result = ($"{result} {num} ,");
        }
    }
    result = ($"{result} = {sum}");
    return result;
}
int number = getUserData("Введите желаемое количество чисел");
string res = SetOfNumbers(number);
Console.WriteLine($"{res}");
