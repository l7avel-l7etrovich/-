/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

System.Console.WriteLine("Эта программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Console.Write("Введите цифру и нажмите Enter!");
int num = Convert.ToInt32(Console.ReadLine());

while (num < 1 || num > 7)
{
    Console.Write("Введте число от 1 до 7! ");
    num = Convert.ToInt32(Console.ReadLine());
}

if (num < 6) //Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
{
    System.Console.WriteLine($"{num} => Нет не выходной");
}
else System.Console.WriteLine($"{num} => Да выходной");

