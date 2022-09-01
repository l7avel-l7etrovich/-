// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

Console.Clear();

int[,] CreateMatrixRndInt(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rnd.Next(0, 10);
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

int[] SumString(int[,] array)
{
    int[] sumNumberRow = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumNumberRow[i] = sum;
    }
    return sumNumberRow;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write($"{array[i],3}, ");
        else Console.Write($"{array[i],3}]");
    }
    Console.WriteLine();
}

int PosMinElement(int[] array)
{
    int index = 1;
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            index = i + 1;
        }
    }

    return index;
}

Console.WriteLine("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Исходный массив: ");

int[,] arrayResult = CreateMatrixRndInt(row, col);
PrintMatrix(arrayResult);
int[] arraySum = SumString(arrayResult);
System.Console.WriteLine();
PrintArray(arraySum); // Для облегчения проверки)
System.Console.WriteLine($"Cтрока с наименьшей суммой элементов: {PosMinElement(arraySum)} Строка ");