﻿//Задача 28: Напишите программу, которая
//принимает на вход число N и выдаёт
//произведение чисел от 1 до N.
//4 -> 24
//5 -> 120

Console.WriteLine("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int Mult(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        mult *= i;
    }
    return mult;
}
int result = Mult(numberN);
Console.WriteLine($"Произведение чисел от 1 до {numberN} = {result}");

