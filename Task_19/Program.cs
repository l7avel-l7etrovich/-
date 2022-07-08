/*Задача 19
Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

System.Console.WriteLine("Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.Write("Введите цифру и нажмите Enter!");
int num = Convert.ToInt32(Console.ReadLine());

while (num < 10000 || num > 99999)
{
    System.Console.WriteLine("Нет, это не пятизначное число! Введите число!");
    num = Convert.ToInt32(Console.ReadLine());
}

int revers = 0;
int temp = num;
while (temp > 0)
{
    revers = revers * 10 + temp % 10;
    temp = temp / 10;
}
if (revers == num)
{
    System.Console.WriteLine("Число является полиндромом!");
}
else System.Console.WriteLine("Число не является полиндромом!");
