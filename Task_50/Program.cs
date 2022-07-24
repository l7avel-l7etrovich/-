// Задача 50. Напишите программу,
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.Clear();
Console.WriteLine("Программа принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.WriteLine("Введите номер строки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер колонки: ");
int y = Convert.ToInt32(Console.ReadLine());

double[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    double[,] array = new double[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return array;
}
void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write("{0:N1} ", array[i, j]);
            else Console.Write("{0:N1} ]", array[i, j]);
        }
        Console.WriteLine();
    }
}
void ElemFind(int i, int j, double[,] array)
{
    if (i <= array.GetLength(0)  && j <= array.GetLength(1))
    {
       Console.WriteLine($"Элемент с индексоми {i} и {j} => {array[i - 1, j - 1] }");
    }
    else Console.WriteLine("Индекс за пределами таблицы. ");
}   

double[,] asd = CreateMatrixRndInt(4, 10, 5, 10);
PrintMatrix(asd);
ElemFind(x, y, asd);

