﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.WriteLine(" Эта программа выдаёт большее или меньшее число. ");
Console.Write(" Введите первое число! ");

int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write(" Ввдите второе число! ");
int num2 = Convert.ToInt32(Console.ReadLine());

if ( num1 < num2 )
{
    Console.Write($"Второе число больше первого: {num1} < {num2} ");
}
else 
{
    Console.WriteLine($" Первое число больше второго : {num1} > {num2} ");
}