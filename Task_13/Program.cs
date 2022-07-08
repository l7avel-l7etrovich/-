//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//
//645 -> 5
//
//78 -> третьей цифры нет
//
//32679 -> 6

int ThirdNum (int num)
{
    while (num >= 1000)
    {
        num = num / 10;
    }
     num = num %10;
    return num;
}

Console.WriteLine("Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет");
Console.Write("Введите число и нажмите Enter!");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100) System.Console.WriteLine("Третьей цифры нет!");
else System.Console.WriteLine($"Третья цифра => {ThirdNum(num)}!");


