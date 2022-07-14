﻿/*Задача 32: Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/

int[] CreateArrayRndInt(int size, int begin, int end) // Метод для получения массива рандомными числами
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(begin, end + 1);

    }
    return array;

}

void PrintArr(int[] array) // Метод вывод на экран массива
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}]");

    }
}

int[] SwapElem(int[] array)
{
    int[] resArr = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        resArr[i] = array[i] * -1;
    }
    return resArr;
}
Console.Write ("Введите размер массива: ");
int insize = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите минимальное число диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите максимальное число диапазона: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] genarr = CreateArrayRndInt(insize, min, max);

int[] swapArr = SwapElem(genarr);

PrintArr(genarr);
PrintArr(swapArr);


