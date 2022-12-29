// Напишите программу, которая на вход принимает координаты двух точек и находит расстояние
// между ними в 2D пространстве

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
double getDistanceCoordinate(int userAx, int userAy, int userBx, int userBy)
{
    double result = Math.Sqrt(Math.Pow((userAx-userBx),2)+Math.Pow((userAy-userBy),2));
    return result;
    Console.WriteLine(result);
}
int userAx = getUserValue("Введите Х");
int userAy = getUserValue("Введите Y");

int userBx = getUserValue("Введите Х");
int userBy = getUserValue("Введите Y");

double distance = getDistanceCoordinate(userAx, userAy, userBx, userBy);
Console.WriteLine($"Растояние между точками {distance}");