// Напишите программу, которая перевернет одномерный массив
//[1 2 3 4 5]->[5 4 3 2 1]
int [] generateArray(int length, int deviation)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-deviation, deviation + 1);
    }
    return array;
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

int[] reverseArray(int[] array)
{
    int fullLength = array.Length;
    int length = array.Length / 2;
    for (int i = 0; i < length; i++)
    {
        int buf = array[i];
        array[i] = array[fullLength - i - 1];
        array[fullLength - i - 1] = buf;
    }
    return array;
}

int[] array = generateArray(11, 20);
printArray(array);
int[] reversed = reverseArray(array);
printArray(reversed);