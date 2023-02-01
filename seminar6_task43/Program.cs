// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double GetFromUser(string message)  // получаем значение элемента от пользователя
{
    Console.WriteLine(message);
    double result = double.Parse(Console.ReadLine()!);
    return result;
}

double b1 = GetFromUser("Введите число b1");
double k1 = GetFromUser("Введите число k1");
double b2 = GetFromUser("Введите число b2");
double k2 = GetFromUser("Введите число k2");

double x = (b2 - b1) / (k1 - k2);
double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;

Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");