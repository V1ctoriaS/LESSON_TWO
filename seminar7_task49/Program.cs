// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
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
            array[i,j] = new Random().Next(start, finish+1 );
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
int[,] Change(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                array[i,j] = (int)Math.Pow(array[i,j], 2); //преобразовываем из double в int (int)
            }
        }
    }
    return array;
}


int n = GetFromUser("Введите число строк");
int m = GetFromUser("Введите число столбцов");
int[,] array = get2DArray(n, m, 0, 100);
print2DArray(array);
Console.WriteLine();
int[,] changed = Change(array);
print2DArray(changed);

