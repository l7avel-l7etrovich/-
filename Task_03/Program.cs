﻿Console.WriteLine("Эта программа выдаёт название дня недели по заданому номеру. Введите цифру от 1 до 7 и нажмите Enter");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
case 1: Console.WriteLine("Понедельник"); break;
case 2: Console.WriteLine("Вторник"); break;
case 3: Console.WriteLine("Среда"); break;
case 4: Console.WriteLine("Четверг"); break;
case 5: Console.WriteLine("Пятница"); break;
case 6: Console.WriteLine("Суббота"); break;
case 7: Console.WriteLine("Воскресенье"); break;
default: Console.WriteLine("Это цифра от 1 до 7"); break;
}