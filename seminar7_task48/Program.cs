// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
// по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

int GetFromUser(string message)  // получаем значение элемента от пользователя
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int[,] get2DArray(int colLength, int rowLength, int start, int finish) //эта функция создает двумерный массив [,]
{
    int[,] array = new int[colLength, rowLength];   //colLength - столбцы, rowLength - строки
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i,j] = i+j;
        }
    }
    return array;
}
void print2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");   //"\t" - задает табуляцию (чтобы таблица была ровная)
        }
        Console.WriteLine();
    }
}

int n = GetFromUser("Введите число строк");
int m = GetFromUser("Введите число столбцов");
int[,] array = get2DArray(n, m, 0, 100);
print2DArray(array);

