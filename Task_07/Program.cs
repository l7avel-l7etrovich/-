//Задача 7: Напишите программу, которая принимает на вход
//трёхзначное число и на выходе показывает последнюю цифру
//этого числа.
//456 -> 6
//782 -> 2
//918 -> 8
Console.WriteLine("Эта программа принимает на вход трёх значное число и на выходе показывает последнюю цифру! ");
Console.WriteLine("Введите число и нажмите Enter. ");

int num = Convert.ToInt32(Console.ReadLine());
int answer;
while (num < 100 || num > 999)
{
    Console.Write("Введено не трёх значное число! Введите трёх значное число! ");
       num = Convert.ToInt32(Console.ReadLine());
 }
answer = num %10;
Console.Write($" Ваше число {answer}! ");
