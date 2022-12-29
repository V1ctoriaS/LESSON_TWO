// See https://aka.ms/new-console-template for more information
// Напишите программу, которая на вход принимает координаты двух точек и находит расстояние
// между ними в 3D пространстве (Домашняя)

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
double getDistanceCoordinate(int userx1, int userx2, int usery1, int usery2, int userz1, int userz2)
{
    double result = Math.Sqrt(Math.Pow((userx2-userx1),2)+Math.Pow((usery2-usery1),2)+Math.Pow((userz2-userz1),2));
    return result;
    Console.WriteLine(result);
}
int userx1 = getUserValue("Введите x1");
int userx2 = getUserValue("Введите x2");

int usery1 = getUserValue("Введите y1");
int usery2 = getUserValue("Введите y2");

int userz1 = getUserValue("Введите z1");
int userz2 = getUserValue("Введите z2");

double distance = getDistanceCoordinate(userx1, userx2, usery1, usery2, userz1, userz2);
Console.WriteLine($"Растояние между точками {distance}");
