﻿//Задача 39: Напишите программу, которая перевернёт
//одномерный массив (последний элемент будет на первом
//месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

int[] CreateArrayRndInt(int size, int begin, int end)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(begin, end + 1);

    }
    return array;
}

void Reverse(int[] array)
{
    int size = array.Length;
    int index1 = 0;
    int index2 = size - 1;

    while (index1 < index2)
{
    int obj = array[index1];
    array[index1] = array[index2];
    array[index2] = obj;

    index1++;
    index2--;
}
}

void PrintArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");

    }
}

int[] array = CreateArrayRndInt(5, 1, 9);
PrintArray (array);
Reverse (array);
Console.WriteLine();
PrintArray (array);