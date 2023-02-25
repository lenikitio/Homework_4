// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

void CreateShowArray()
{
    Console.Write("[");
    int[] arrey = new int[8];
    int arreyLenght = arrey.Length;
    for (int i = 0; i < arreyLenght; i++)
    {
        arrey[i] = new Random().Next(0, 100);
        Console.Write(arrey[i]);
        Console.Write(i == arreyLenght - 1 ? "]" : ", ");
    }
}

CreateShowArray();