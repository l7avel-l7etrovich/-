//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76 

Console.Clear();
double[] array = { 3.5, 7.1, 22.9, 2.3, 78.5 };

void PrintArr(double[] arr) // Печатает массив
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0)
            Console.Write("[");
        if (i < arr.Length - 1)
            Console.Write(arr[i] + ", ");
        else
            Console.Write(arr[i] + "]");
    }
}

double Max(double[] arr) // Выводит МАХ элемент масива
{
    double max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
    }
    return max;
}

double Min(double[] arr) // Выводит MIN элемент масива
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
            min = arr[i];
    }
    return min;
}

Console.Write("Исходный массив: ");
PrintArr(array);
Console.WriteLine();
double resMin = Min(array);
double resMax = Max(array);
double result = resMax - resMin;
Console.Write($"Разница между максимальным и минимальным значениями массива: {result}");
