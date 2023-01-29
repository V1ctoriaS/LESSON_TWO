// Напишите программу замена эелементов массива: положительные элементы заменить на соответствующие 
//отрицательные и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] generateArray(int length, int start, int end)   // эта функция создает массив
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(start, end + 1);    //+1 потому что поумолчанию последнее значение не используется рандомайзером
    }
    return result;
}
int getInFromUser(string message)   //принимаем массив от пользователя
{
    Console.WriteLine(message);
    int userInt = int.Parse(Console.ReadLine()!);
    return userInt;
}

int[] invertArray(int[] arrayToInvert)      //инвертируем полученный ранее массив в отрицательные элементы и наоборот
{
    for (int i = 0; i < arrayToInvert.Length; i++)
    {
        arrayToInvert[i] = -arrayToInvert[i];
    }
    return arrayToInvert;
}

void printArray(int[] array)       //эта функция выводит ранее созданный массив на печать
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] );
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}


int length = getInFromUser("Введите длину массива");
int[] array = generateArray(length, -100,100);
printArray(array);
int[] invertedArray = invertArray(array);
printArray(invertedArray);