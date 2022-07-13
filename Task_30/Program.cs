//Решение в группах задач:
//Задача 30: Напишите программу, которая
//выводит массив из 8 элементов, заполненный
//нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]
//12

int[] array = new int[9];

int[] ArrayBin(int size) // Создаёт массив с рандомными элементами
{
    int[] array = new int[size];
    int index = 0;

    Random rnd = new Random();
    while (index < array.Length)
    {
        array[index] = rnd.Next(0, 2);
        index++;
    }
    return array;
}


void PrintArray(int[] arr) // Печатает массив
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(array[i] + ",");
        else Console.WriteLine(array[i] + "]");

    }
}

int[] resArray = ArrayBin(9);
PrintArray(resArray);