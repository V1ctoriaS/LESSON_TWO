// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли 
//существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

bool IsTriangleExist(int a, int b, int c)   //функция true or false
{
    bool isExist = false;
    if(a < b + c && b < a + c && c < b + a)
    {
        isExist = true;
    }
    return isExist;
}

int a = getUserData("Введите длину стороны А");
int b = getUserData("Введите длину стороны B");
int c = getUserData("Введите длину стороны C");
bool isExist = IsTriangleExist(a,b,c);

Console.WriteLine($"Треугольник со сторонами [{a}, {b}, {c}] {((isExist)? "существует":"не существует")}");

//string str = (isExist)? "существует":"не существует";      //эта функция проверяет true или false и выводит вывод

/*if (isExist)   //эта функция равна функции на строке 31
{
    str = "существует";
}
else
{
    str = "не существует";
}
*/