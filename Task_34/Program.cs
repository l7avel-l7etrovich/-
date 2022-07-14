/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);

    }
    return array;
}

int EvenNum(int[] array)
{
    int num = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            num += 1; 
        }
    }
    return num;
}

void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}]");

    }
}

Console.Write("Введите размер массива: ");
int insize = Convert.ToInt32(Console.ReadLine());

int[] genarr = CreateArrayRndInt(insize);
PrintArr(genarr);
int evennum = EvenNum(genarr);
Console.WriteLine($" => {evennum}");
