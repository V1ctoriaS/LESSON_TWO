// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
// натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int getSum(int A, int B)
{
    int sum = 1;
    for (int i = 1; i <= B; i++)
    {
        sum = sum * A;          
    }
    return sum;
}


int A = getUserData("Введите первое число");
int B = getUserData("Введите второе число");

int sum = getSum(A, B);
Console.WriteLine($"Степень {sum}");