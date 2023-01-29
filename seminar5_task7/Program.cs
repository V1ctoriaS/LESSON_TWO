// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и 
//последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

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

int [] newarray (int [] array)
{
    int newlength = (int) Math.Ceiling(array.Length/2.0);   //2.0 чтобы делились и дробные числа и округлялись до большего целого
    int [] arr = new int [newlength];
    for (int i = 0; i < newlength; i++)
    {
        if (i < newlength - 1)
        {
            arr [i] = array [i] * array[array.Length-i-1];
        }
        else
        {
            arr[i] = array[i];
        }
    }
    return arr;
}

int length = getInFromUser("Введите длину массива");
int[] array = generateArray(length, -100,100);
printArray(array);
int [] array2 = newarray(array);
printArray(array2);