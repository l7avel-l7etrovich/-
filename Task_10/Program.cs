/*Задача 10: Напишите программу, 
которая принимает на вход трёхзначное число и на 
выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/
int SecondNum(int num) //Второе число из трехзначного числа.
{
    int answer;
    answer = num % 100 / 10;
    return answer;
}

Console.WriteLine("Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
Console.Write("Введите число и нажмите Enter!");
int num = Convert.ToInt32(Console.ReadLine());
while (num < 100 || num > 999)
{
    Console.Write("Введено не трёх значное число! Введите трёх значное число! ");
    num = Convert.ToInt32(Console.ReadLine());
}
int sec = SecondNum(num);
Console.Write($"Втрое число => {sec}! ");

