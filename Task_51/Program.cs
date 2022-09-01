﻿//Задача 51: Задайте двумерный массив. Найдите сумму
//элементов, находящихся на главной диагонали (с индексами
//(0,0); (1;1) и т.д.


Console.Clear();

Console.WriteLine("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное число диапазона: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    System.Console.WriteLine($"Сгенерированная матрица: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3}, ");
            else Console.Write($"{array[i, j],3}]"); 
        }
        Console.WriteLine();
    }
}

int SumMainDiag(int[,] array)
{
int sumElMainDiag = 0;
int index = array.GetLength(0) > array.GetLength(1) ? 1 : 0;

for (int i = 0; i < array.GetLength(index); i++)
{
sumElMainDiag += array[i, i];
}
return sumElMainDiag;
}

int [,] genArray = CreateMatrixRndInt(m, n, min, max);
PrintMatrix(genArray);
int resSum = SumMainDiag(genArray);
System.Console.WriteLine($"Сумма элементов, находящихся на главной диагонали равна {resSum}");